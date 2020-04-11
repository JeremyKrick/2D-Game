using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;

    Vector2 movement;
    Vector2 mousePos;
    public float MoveSpeed = 4f;
    public Camera cam;

    // Get Input from User in Update. Called once per frame.
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }

    // Move in FixedUpdate to have smooth movement with physics
    public void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * MoveSpeed * Time.fixedDeltaTime);

        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
    }
}
