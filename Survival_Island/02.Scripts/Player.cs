using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(NavMeshAgent))]
// ���� ī�޶󿡼� ray�� ��� �÷��̾ �װ��� �̵� �ϴ� ��ũ��Ʈ

public class Player : MonoBehaviour
{
    private string idleAndMove = "Speed";
    private string skill = "Skill";
    private string jump = "Jump";
    private string attack = "Attack";
    private string runAttack = "RunAttack";

    private Transform tr;
    private Ray ray;
    private RaycastHit hit;

    [SerializeField]
    [Tooltip("�ִϸ��̼� ������Ʈ")]
    private Animator animator;

    [SerializeField]
    [Tooltip("������̼� �޽� ������Ʈ ������Ʈ")]
    private NavMeshAgent agent;

    private Vector3 target = Vector3.zero;

    [SerializeField]
    private float m_doubleClickSecond = 0.25f;
    [SerializeField]
    private bool isOneClick = false;
    [SerializeField]
    private float m_time = 0f;
    
    void Start()
    {
        animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        tr = GetComponent<Transform>();
        
    }

    void Update()
    {
        CameraRay();

        ClickDoubleClick();

        MouseMovement();

        if (Input.GetMouseButtonDown(1))
        {
            if (agent.speed == 6f)
                animator.SetTrigger(runAttack);
            else
                animator.SetTrigger(attack);
        }
        if (Input.GetMouseButtonDown(2) && Input.GetKey(KeyCode.LeftShift))
        {
            agent.isStopped = true;
            agent.speed = 0;
            agent.ResetPath(); // ����� ��� �ʱ�ȭ
            agent.velocity = Vector3.zero;
            animator.SetTrigger(skill);
        }
        else if (Input.GetMouseButtonDown(2))
        {
            animator.SetTrigger(skill);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger(jump);
        }


    }

    private void MouseMovement()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out hit, 100f, 1 << 8))
            {
                target = hit.point;
                agent.destination = target;
                agent.isStopped = false;

                agent.speed = isOneClick ? 3f : 6f;

                animator.SetFloat(idleAndMove, agent.speed, 0.0002f, Time.deltaTime);
            }
        }
        else
        {
            if (agent.remainingDistance < 0.3f)
            {
                agent.isStopped = true;
                agent.speed = 0f;
                animator.SetFloat(idleAndMove, agent.speed, 0.02f, Time.deltaTime);
            }
        }
    }

    private void ClickDoubleClick()
    {

        if (isOneClick && (Time.time - m_time) > m_doubleClickSecond)
        {
            isOneClick = false;
        }

        if (Input.GetMouseButtonDown(0))
        {
            if (!isOneClick)
            {
                isOneClick = true;
                m_time = Time.time;
            }
            else if (isOneClick && (Time.time - m_time) < m_doubleClickSecond)
            {
                isOneClick = false;
            }
        }
        
    }

    private void CameraRay()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin, ray.direction * 100, Color.blue);
    }
}
