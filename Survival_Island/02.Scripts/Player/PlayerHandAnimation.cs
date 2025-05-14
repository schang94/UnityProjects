using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ���ʽ���ƮŰ�� WŰ�� ���ÿ� ������ �� �ִϸ��̼�(���� ����)�� ����ϴ� ��ũ��Ʈ
// �� �� �ϳ��� ���� �ִϸ��̼��� ���߰� ���� �ܴ��� �ִϸ��̼� ����� ����
public class PlayerHandAnimation : MonoBehaviour
{
    private readonly string running = "running";
    private readonly string runStop = "runStop";
    private readonly string fire = "fire";
    private bool isRun;
    public Animation anim;
    void Start()
    {
        anim = transform.GetChild(0).GetChild(0).GetComponent<Animation>();
        //anim = GetComponentsInChildren<Animation>()[0];
        isRun = false;
    }

    void Update()
    {
        RunningAni();
        PlyerFire();
    }

    public void PlyerFire()
    {
        if (Input.GetMouseButton(0) && !isRun)
        {
            anim.Play(fire);
        }
    }

    private void RunningAni()
    {
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.W))
        {
            anim.Play(running);
            isRun = true;
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift) || Input.GetKeyUp(KeyCode.W))
        {
            anim.Play(runStop);
            isRun = false;
        }
    }
}
