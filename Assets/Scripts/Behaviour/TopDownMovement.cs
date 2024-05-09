using System;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    [SerializeField]
    private TopDownController controller;
    private Rigidbody2D rigidbody;

    private Vector2 movementDirection = Vector2.zero;

    private void Awake()
    {
        controller = GetComponent<TopDownController>();
        rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        controller.OnMoveEvent += Move;
    }

    private void FixedUpdate()
    {
        ApplyMovement(movementDirection);
    }


    private void Move(Vector2 direction)
    {
        movementDirection = direction;
    }
    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * 5;
        rigidbody.velocity = direction;
    }
}