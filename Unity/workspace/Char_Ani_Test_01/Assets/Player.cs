﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float moveSpeed = 5f;
    public float rotationSpeed = 360f;

    CharacterController characterController;
    Animator animator;

	void Start () {
        characterController = GetComponent<CharacterController>();
        animator = GetComponentInChildren<Animator>();
	}
	
	void Update () {
        Vector3 direction =
            new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        if (direction.sqrMagnitude > 0.01f) {
            Vector3 forward = Vector3.Slerp(
                transform.forward,
                direction,
                rotationSpeed * Time.deltaTime /
                Vector3.Angle(transform.forward, direction)
                );
            transform.LookAt(transform.position + forward);
        }
        characterController.Move(direction * moveSpeed * Time.deltaTime);
        animator.SetFloat("Speed", characterController.velocity.magnitude);
	}
}
