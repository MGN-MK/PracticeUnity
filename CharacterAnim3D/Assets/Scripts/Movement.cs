using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        //The player woll walk presing W
        if(Input.GetKey(KeyCode.W) && !animator.GetBool("isWalking"))
        {
            //Var walking gonna be true
            animator.SetBool("isWalking", true);
        }

        //Starts running
        if ((Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.W)) && !animator.GetBool("isRunning"))
        {
            animator.SetBool("isRunning", true);
        }

        //Stops running
        if (animator.GetBool("isRunning") && !Input.GetKey(KeyCode.LeftShift))
        {
            animator.SetBool("isRunning", false);
        }

        //Stops walking
        if (animator.GetBool("isWalking") && !Input.GetKey(KeyCode.W))
        {
            animator.SetBool("isWalking", false);
            animator.SetBool("isRunning", false);
        }

        //Attacks once when left click is pressed
        if(Input.GetMouseButton(0) && !animator.GetBool("isAttacking"))
        {
            animator.SetBool("isAttacking", true);
        }

        //Stops attacking
        if(animator.GetBool("isAttacking") && !Input.GetMouseButton(0))
        {
            animator.SetBool("isAttacking", false);
        }

        //Jumps when space is pressed
        if(Input.GetKey(KeyCode.Space) && !animator.GetBool("isJumping"))
        {
            animator.SetBool("isJumping", true);
        }

        //Stops Jumping
        if(animator.GetBool("isJumping") && !Input.GetKey(KeyCode.Space))
        {
            animator.SetBool("isJumping", false);
        }
    }
}
