    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class PlayerMovementSnällaFunka : MonoBehaviour
    {

        public CharacterController2D controller;
        //public Animator animator;

        public float runSpeed = 10f;

        float HorizontalMove = 0f;
        bool jump = false;

         //Update is called once per frame
        void Update()
        {
            HorizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
         //   animator.SetFloat("Speed", Mathf.Abs(HorizontalMove));

            Debug.Log(HorizontalMove);

         /*   if (Input.GetButtonDown("Jump"))
            {
                jump = true;
                animator.SetBool("IsJumping", true);
            } */
        }

        void FixedUpdate ()
        {
            //Move our character
            controller.Move(HorizontalMove * Time.fixedDeltaTime, false,  jump);
            jump = false;
        }
    }
