using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Animator animator;

    private CharacterController charactercontroller;

    void Start()
    {
        animator = GetComponent<Animator>();
        charactercontroller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float move = Input.GetAxis("Vertical");


        // for a vertical animation 
        charactercontroller.Move(new Vector3(0, 0, move) * Time.deltaTime);
        animator.SetFloat("Speed", move);

        if (Input.GetKey(KeyCode.LeftShift))
        {
            animator.SetBool("Run", true);
        }
        else
        {
            animator.SetBool("Run", false);
        }



    }






}
