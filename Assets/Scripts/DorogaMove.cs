using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DorogaMove : MonoBehaviour
{
    Vector3 moveVec;
    float MoveSpeed = 5;

    void Start()
    {
        moveVec = new Vector3(-1, 0, 0);
    }

    void Update()
    {
        transform.Translate(moveVec * Time.deltaTime * MoveSpeed);
    }
}