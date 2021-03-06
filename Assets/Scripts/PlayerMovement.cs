﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerMovement : MonoBehaviour {

    public float speed;

    private Rigidbody2D rb;

    private Vector2 moveVelocity;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update () {

        Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        moveVelocity = moveInput.normalized * speed;

	}

    void FixedUpdate()
    {

        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);

    }
}
