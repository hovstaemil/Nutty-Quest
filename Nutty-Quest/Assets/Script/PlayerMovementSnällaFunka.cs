    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class PlayerMovementSnällaFunka : MonoBehaviour
    {

        public CharacterController2D controller;
        public Animator animator;

        public float runSpeed = 40f;        //chooses the speed of ekorren

        float horizontalMove = 0f;
        bool jump = false;

        // Update is called once per frame
        void Update()
        {

            horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

            animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

            if (Input.GetButtonDown("Jump"))            //when the jump button is pressed it change the animation to HOPPAR if ekorren is in the air
            {
                Debug.Log("HOPPAR");
                jump = true;
                animator.SetBool("IsJumping", true);
            }
        }

        public void OnLanding()             //when ekorren has landed it changes the animation back
        {
            animator.SetBool("IsJumping", false);
        }

        void FixedUpdate()
        {
            // Move our character
            Debug.Log(horizontalMove);    
            controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
            jump = false;
        }
}
