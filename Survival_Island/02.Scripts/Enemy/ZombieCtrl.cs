using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

// NavMeshAgent�� �̿��Ͽ� �÷��̾ ���� �����ȿ� ������
// �����ϰ� ���� �����ȿ� ������ �����ϴ� ���� ������ �ִϸ��̼� ����

// �������� ���ݹ����� ���Ϸ��� �Ÿ��� ���ؾ���. �÷��̾�� ������ ��ġ�� �˾ƾ���
[RequireComponent(typeof(NavMeshAgent))]
[RequireComponent(typeof(Animator))]

public class ZombieCtrl : MonoBehaviour
{
    private readonly string traceTxt = "IsTrace";
    private readonly string attackTxt = "IsAttack";
    private readonly string playerTxt = "Player";

    private readonly int hashTrace = Animator.StringToHash("IsTrace");
    private readonly int hashAttack = Animator.StringToHash("IsAttack");

    [SerializeField] private NavMeshAgent agent;
    [SerializeField] private Animator animator;
    [SerializeField] private Transform zombieTr;
    [SerializeField] private Transform playerTr;
    public float traceDist = 20.0f;
    public float attackDist = 3.0f;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        zombieTr = GetComponent<Transform>();
        playerTr = GameObject.FindWithTag(playerTxt).transform;
    }

    void Update()
    {

        float dist = Vector3.Distance(zombieTr.position, playerTr.position);
        if (dist <= attackDist)
        {
            animator.SetBool(hashAttack, true);
            agent.isStopped = true;
        }
        else if (dist <= traceDist)
        {
            animator.SetBool(hashAttack, false);
            animator.SetBool(hashTrace, true);
            agent.isStopped = false;
            agent.destination = playerTr.position;
        }
        else
        {
            animator.SetBool(hashTrace, false);
            agent.isStopped = true;
        }
    }
}
