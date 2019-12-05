using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CowBoyController : MonoBehaviour {
    public Animator PlayerAnimator;
    public float RndNumb;
    // Use this for initialization
    void Update()
    {
        if(Input.GetButton("Horizontal")){
<<<<<<< HEAD
            PlayerAnimator.SetFloat("RndGen", 0.5f);
        }else if(Input.GetButtonUp("Horizontal")){
            PlayerAnimator.SetFloat("RndGen", 0f);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            PlayerAnimator.SetFloat("RndGen", 1f);
        }
        else if (Input.GetButtonUp("Vertical"))
        {
            PlayerAnimator.SetFloat("RndGen", 0f);
        }
        if (Input.GetKey(KeyCode.S))
        {
=======
>>>>>>> parent of b17d64e... fgf
            PlayerAnimator.SetFloat("RndGen", 1f);
        }else if(Input.GetButtonUp("Horizontal")){
            PlayerAnimator.SetFloat("RndGen", 0f);
        }
    }


}
