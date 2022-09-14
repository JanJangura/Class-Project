// Asterik in the name of the folder, check the tabs, means it's not saved.
//Libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//The main class of this script
public class CloudFloat : MonoBehaviour // MonoBehavior allows 
{
    public float speed = 0.1f; // Think of it as an archive. 
    // Start is called before the first frame update
    // This is a function, you can look at it like a formula to do stuff
    // Start is the name of the function. 
    void Start() //This function is that start of the game, Start is called before the first frame update
    {
        //  Debug.Log("Hello World"); //We're debugging a message for the debugger or programmer, not the game. Can help us debug a bug in the future when updating.
        Debug.Log(this.name); // This will indicate the name of the cloud named from Unity. 
        //
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("Frame"); //We're debugging a message for the debugger or programmer, not the game. Can help us debug a bug in the future when updating.
        this.transform.position = new Vector3(this.transform.position.x,
            this.transform.position.y,
            this.transform.position.z + (speed * Time.deltaTime) /*Any time you write a decimal in C#, you have to add an "f" behind it*/ ); // We have to change the position of the entire vector, not just one value of the vector. 
                                                                                                                                             // this (a script that's talking about this. Transform is the position of the object). We are accessing the firewalls of these objects. 
                                                                                                                                             // We will use a vector to change the position of the object. 
        Debug.Log(speed * Time.deltaTime); // This will display the speed basically in Unity.
    } // (0.1f * Time.deltaTime) This will slow down the frame basically
}
