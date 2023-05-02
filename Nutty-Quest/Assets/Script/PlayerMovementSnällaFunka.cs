    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class PlayerMovementSnällaFunka : MonoBehaviour
    {

        public CharacterController2D controller;
        public Animator animator;

        public float runSpeed = 40f;

        float horizontalMove = 0f;
        bool jump = false;

        // Update is called once per frame
        void Update()
        {

            horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

            animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

            if (Input.GetButtonDown("Jump"))
            {
                Debug.Log("HOPPAR");
                jump = true;
                animator.SetBool("IsJumping", true);
            }
        }

        public void OnLanding()
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
