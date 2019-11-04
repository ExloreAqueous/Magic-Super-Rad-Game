using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour {
    public CharacterController2D controller;
    public float runspeed = 40F;
    float horizontalmove = 0f;
    bool jump = false;
    private void Update()
    {
        horizontalmove = Input.GetAxisRaw("Horizontal") * runspeed;
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
    }
    private void FixedUpdate()
    {
        controller.Move(horizontalmove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }












    //public float speed;

    //private Rigidbody2D rb;
    //private Vector2 moveVelocity;

    //void Start()
    //{
    //    rb = GetComponent<Rigidbody2D>();
    //}
    //void Update()
    //{
    //    Vector2 moveinput = new Vector2(Input.GetAxis("Hprizontal"), Input.GetAxis("Vertical"));
    //    moveVelocity = moveinput * speed;
    //}
    //void FixedUpdate()
    //{
    //    rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    //}
}
