using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 왼쪽쉬프트키와 W키를 동시에 눌렀을 때 애니메이션(총을 접는)을 재생하는 스크립트
// 둘 중 하나라도 때면 애니메이션이 멈추고 총을 겨누는 애니메이션 재생을 구현
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
