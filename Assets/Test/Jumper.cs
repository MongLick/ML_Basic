using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public Rigidbody rigid;
    public float jumpPower;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.LogError("����ǥ��");
            Debug.LogWarning("���ǥ��");
            Debug.Log("����ǥ��");
            rigid.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
        }
    }
}
