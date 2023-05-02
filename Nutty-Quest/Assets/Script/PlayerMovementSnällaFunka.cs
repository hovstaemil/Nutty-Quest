    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class PlayerMovementSnällaFunka : MonoBehaviour
    {

        public CharacterController2D controller;
        //public Animator animator;
        private Vector2 velocity;
        public float runSpeed = 10f;
        bool jump = false;

        void Start()
        {
        }

        void Update ()
        {
            float horizontal = Input.GetAxis("Horizontal");

            velocity = (transform.position * horizontal * Time.deltaTime);
            
            CharacterController2D.Move(velocity, false, false);
        }
    }
