using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ������ z������ �߻�
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
