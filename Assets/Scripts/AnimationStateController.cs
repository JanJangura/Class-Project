using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStateController : MonoBehaviour
{
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
        bool spaceBar = Input.GetButtonDown("Jump");        
        bool isJumping = animator.GetBool("IsJumping");     // Bools are set to false by default
        // If player presses SpaceBar
        if (!isJumping && spaceBar)
        {
            // If the space bar is pressed, then the bool is set to true.
            animator.SetBool("IsJumping", true);
        }
        // If player let's go of SpaceBar
        if (isJumping && !spaceBar)
        {
            // If the space bar is not pressed, then the bool is set to false.
            animator.SetBool("IsJumping", false);
        }

    }
}
