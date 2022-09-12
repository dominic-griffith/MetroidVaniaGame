using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    //public Animator animator;
    public float walkSpeed = 40f;
    public float runSpeed = 80f;

    private float horizontalMove = 0f;
    private bool jump = false;
    private bool isRunning = false;


    private void Update()
    {
        GetInput();  
    }

    private void FixedUpdate()
    {
        MoveCharacter();
    }

    private void GetInput()
    {
        if(isRunning)
            horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        else
            horizontalMove = Input.GetAxisRaw("Horizontal") * walkSpeed;

        //animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            //animator.SetBool("Jump", true);
        }

        if(Input.GetKey(KeyCode.LeftShift))
        {
            isRunning = true;
        }
        else
        {
            isRunning = false;
        }
    }

    //public void OnLanding()
    //{
    //    animator.SetBool("Jump", false);
    //}

    private void MoveCharacter()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
