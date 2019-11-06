using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour {
    private Rigidbody2D rb;

    private Vector2 moveVelocity;

    public CharacterController2D controller;

    public float runspeed = 40F;

    float horizontalmove = 0f;

    bool jump = false;

    public void Update()
    {
        horizontalmove = Input.GetAxisRaw("Horizontal") * runspeed;
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
        Vector2 moveinput = new Vector2(Input.GetAxis("Hprizontal"), Input.GetAxis("Vertical"));
        moveVelocity = moveinput * runspeed;
    }

    public void FixedUpdate()
    {
        controller.Move(horizontalmove * Time.fixedDeltaTime, false, jump);
        jump = false;
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    
}
