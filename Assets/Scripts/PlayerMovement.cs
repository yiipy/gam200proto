using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject passenger1start;
    public GameObject passenger1end;
    public GameObject passenger1onboat;

    public float moveSpeed = 5f;

    public Rigidbody2D rb;
    public Animator animator;

    Vector2 movement;

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x); // -1 = left, 1 = right
        animator.SetFloat("Vertical", movement.y); // -1 = down, 1 = up
        animator.SetFloat("Speed", movement.sqrMagnitude); // more than 0.01 = moving

        if (passenger1start.activeInHierarchy == false && passenger1end.activeInHierarchy == false)
        {
            passenger1onboat.SetActive(true);
        }
        else
        {
            passenger1onboat.SetActive(false);
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}