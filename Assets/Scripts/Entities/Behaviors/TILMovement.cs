using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TILMovement : MonoBehaviour
{
    private TILController controller;
    private Rigidbody2D movementRigidBody;

    private Vector2 movementDirection = Vector2.zero;

    private void Awake()
    {
        controller = GetComponent<TILController>();
        movementRigidBody = GetComponent<Rigidbody2D>();

    }

    private void Start()
    {
        controller.OnMoveEvent += Move;
    }

    private void Move(Vector2 direction)
    {
        movementDirection = direction; 
    }

    private void FixedUpdate()
    {
        ApplyMovement(movementDirection);
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * 5; //TODO: 속도 스탯값 넣기(characterStathandler)
        movementRigidBody.velocity = direction;
    }
}
