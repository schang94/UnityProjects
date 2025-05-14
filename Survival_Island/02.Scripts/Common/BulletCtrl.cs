using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 스스로 z축으로 발사
public class BulletCtrl : MonoBehaviour
{
    public float speed = 50.0f;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * speed);
    }

}
