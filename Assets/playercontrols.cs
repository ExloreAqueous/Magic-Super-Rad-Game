using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontrols : MonoBehaviour {

    Rigidbody2D myrb;
    float xspeed;

    private bool isGrounded;
    public Transform feetPos;
    public float checkRadius;
    public LayerMask whatisGround;
    public float jumpforce;




    // Use this for initialization
    void Start()
    {
        myrb = this.GetComponent<Rigidbody2D>();

    }
    void FixedUpdate()
    {
        myrb.velocity = new Vector2(xspeed, myrb.velocity.y);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            xspeed = 5;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            xspeed = -5;
        }
        else
        {
            xspeed = 0;
        }
        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatisGround);
        if(isGrounded == true && Input.GetKeyDown(KeyCode.Space))
        {
            myrb.velocity = Vector2.up * jumpforce;
        }
    }
    
}
