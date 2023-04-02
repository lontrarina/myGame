using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D Controller;
    public Animator Animator;

    public float RunSpeed = 40f;
    float horizontalMove = 0f;
    bool jump=false;

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * RunSpeed;

        Animator.SetFloat("Speed",Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            Animator.SetBool("IsJumping",true);
        }
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
