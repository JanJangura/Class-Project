using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thwmp : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision) // This is the 2D version of On Trigger
    {
        if (collision.gameObject.tag == "Player") // This means that if the game object has a tag called player, then it will destory the objects.
        {
            // This will destory the other objects touching 
            Destroy(collision.gameObject); // Destroy will destroy an object from the scene using the collider2D.
        }
        
    }
    // Will work with collisions instead of just triggers
    // A little more complicated to use, not terrible though
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }

}
