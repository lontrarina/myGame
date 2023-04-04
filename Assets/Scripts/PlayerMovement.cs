using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D Controller;
    public Animator Animator;
    public Joystick Joystick;

    public float RunSpeed = 40f;
    float horizontalMove = 0f;
    bool jump=false;

    void Update()
    {
        //horizontalMove = Input.GetAxisRaw("Horizontal") * RunSpeed;

        horizontalMove = Joystick.Horizontal * RunSpeed;

        float verticalMove = Joystick.Vertical;
        Animator.SetFloat("Speed",Mathf.Abs(horizontalMove));

        if (verticalMove >= .5f)
        {
            jump = true;
            Animator.SetBool("IsJumping", true);
        }


        //if (Input.GetButtonDown("Jump"))
        //{
        //    jump = true;
        //    Animator.SetBool("IsJumping",true);
        //}
    }

    public void OnLanding()
    {
        Animator.SetBool("IsJumping",false);
    }
    void FixedUpdate()
    {
        Controller.Move(horizontalMove*Time.fixedDeltaTime, false, jump);
        jump= false;
    }

}
