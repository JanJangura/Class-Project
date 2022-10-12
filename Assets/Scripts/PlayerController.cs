using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Reference to the character controller that handles our colissions and movement
    public CharacterController controller;
    //
    public float speed = 1f;

    // Update is called once per frame
    void Update()
    {
        // Step 1 get current position
        Vector3 currentPos = transform.position;
        Vector3 motion = Vector3.zero;

        // Step 2 get player input
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        // Step 3 set new position based on input and speed
        // The new value of currentpos in x will be its current value, plus the speed
        // Multiplied by the input (-1 or 1) and time.deltaTime.
        currentPos.x = currentPos.x + speed * inputX * Time.deltaTime;

        // Step 4 repeat the same with Z
        currentPos.z = currentPos.z + speed * inputY * Time.deltaTime;

        // This will get us the vector of our movement, instead of the new position
        // motion.z = transform.forward.normalized.z * speed * inputY * Time.deltaTime;
        // motion.x = transform.forward.normalized.x * speed * inputX * Time.deltaTime;

        motion = (transform.forward.normalized * speed * inputY * Time.deltaTime)
            + (transform.right * speed * inputX * Time.deltaTime);

        // Step 5 assign new position
        // transform.position = currentPos;

        // Instead of moving it normally, we can use the character controller for motion
        controller.Move(motion);
            
    }
}
