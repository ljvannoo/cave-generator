﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody rigidbody;
    Vector3 velocity;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        velocity = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized * 10;
    }

    void FixedUpdate() {
        rigidbody.MovePosition(rigidbody.position + velocity * Time.fixedDeltaTime);
    }
}
