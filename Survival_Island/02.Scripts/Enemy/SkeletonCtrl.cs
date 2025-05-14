using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
[RequireComponent(typeof(Animator))]

public class SkeletonCtrl : MonoBehaviour
{
    private readonly string playerTxt = "Player";
    private readonly string traceTxt = "IsTrace";
    private readonly string attackTxt = "IsAttack";
     // 동적할당과 동시에 문자열을 읽어서 정수로 변환
    private readonly int hashTrace = Animator.StringToHash("IsTrace");
    private readonly int hashAttack = Animator.StringToHash("IsAttack");
    [SerializeField] private NavMeshAgent agent;
    [SerializeField] private Animator animator;
    [SerializeField] private Transform skeletonTr;
    [SerializeField] private Transform playerTr;

    private float traceDist = 20f;
    private float attackDist = 3f;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        skeletonTr = GetComponent<Transform>();
        playerTr = GameObject.FindWithTag(playerTxt).transform;
    }

    void Update()
    {
        float dist = Vector3.Distance(skeletonTr.position, playerTr.position);

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
