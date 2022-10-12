using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingScript : MonoBehaviour
{
    public Rigidbody reggiebody;
    public float jumpForce; // Jump Force is 4xs the force. jumpForce is a function that will be added on to Unity as well.

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") && Time.timeScale >= 1f) // Reference to the managment settings on Unity to match the jump button. Then the Time.timeScale means
            // that if the run time of isPaused it less than 1f, which is 0f, then this function won't work. Only when it is not pause will it work.
        {
            //reggiebody.AddForce(new Vector3(1,1,0) * jumpForce);
            reggiebody.AddForce(Vector3.up * jumpForce); // Vector, reference to Calc 3. 
            // Vector is the direction in which the object will jump, then jumpForce is how much force you want the object to jump. So then to do that
            // you will multiply the vector to the jump force to increase the height at which you want how high the object will jump.
        }
    }
}


// TIME Scale, a global variable. 