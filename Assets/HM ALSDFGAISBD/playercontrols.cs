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
    private float jumpTimecounter;
    public float jumpTime;
    private bool isJumping;


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
            xspeed = 3;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            xspeed = -3;
        }
        else
        {
            xspeed = 0;
        }
        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatisGround);
        if(xspeed > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }else if (xspeed < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
        if(isGrounded == true && Input.GetKeyDown(KeyCode.Space))
        {
            isJumping = true;
            jumpTimecounter = jumpTime;
            myrb.velocity = Vector2.up * jumpforce;
        }
        if (Input.GetKey(KeyCode.Space) && isJumping == true)
        {
            myrb.velocity = Vector2.up * jumpforce;
            jumpTimecounter -= Time.deltaTime;
        }
        else
        {
            isJumping = false;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            isJumping = false;
        }
    }
    
}
