using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{

    public GameObject character;
    public float jumpSpeed;
    public Rigidbody2D rb;

    void OnCollisionEnter2D()
    {
        character.transform.tag = "onFloor";
    }

    void OnCollisionExit2D()
    {
        character.transform.tag = "Jumping";
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            character.transform.Translate(new Vector3(3.25f, 0, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            character.transform.Translate(new Vector3(-3.25f, 0, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            character.transform.Translate(new Vector3(-3.25f, 0, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            character.transform.Translate(new Vector3(-3.25f, 0, 0));
        }
    }
}