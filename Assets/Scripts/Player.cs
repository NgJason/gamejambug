﻿using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{

    CharacterController c;
    public float moveSpeed = 2;
    private Vector3 pos;
    // Use this for initialization

    void Start()
    {
        c = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        pos = Vector3.zero;
        pos = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        pos = transform.TransformDirection(pos);
        pos *= moveSpeed;

        c.Move(pos * Time.deltaTime);
    }
}
