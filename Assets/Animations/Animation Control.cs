using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControl : MonoBehaviour
{
    public Animator animator;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Jump"))
        {
            // Go to the animator and set the bool paramater called "Grow" to true
            animator.SetBool("Grow", true);
        }
        // Otherwise set it to false
        else
            animator.SetBool("Growing", false);

        // A one-line way of writing it
        // animator.setBool("Growing", Input.GetButton("Jump"));

        int X = Mathf.RoundToInt(Input.GetAxis("Horizontal"));
        animator.SetInteger("AD", X);

        int Y = Mathf.RoundToInt(Input.GetAxis("Vertical"));
        animator.SetInteger("WS", Y);
    }
}
