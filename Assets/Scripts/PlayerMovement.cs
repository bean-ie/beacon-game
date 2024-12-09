using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEditor.Timeline.TimelinePlaybackControls;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float pushForce;
    [SerializeField] float maxSpeed;

    Rigidbody2D rb;
    PlayerControls playerControls;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

        playerControls = new PlayerControls();

        playerControls.Player.Move.Enable();
    }

    private void FixedUpdate()
    {
        Vector2 movementVector = playerControls.Player.Move.ReadValue<Vector2>();
        rb.AddForce(movementVector.normalized * pushForce);
        rb.velocity = Vector2.ClampMagnitude(rb.velocity, maxSpeed);
    }

    public void SetSpeed(float movementSpeed = 2000, float maxSpeed = 10)
    {
        pushForce = movementSpeed;
        this.maxSpeed = maxSpeed;
    }
}
