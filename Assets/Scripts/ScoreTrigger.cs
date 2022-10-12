using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreTrigger : MonoBehaviour
{
    static int score = 0;   // The static keyword makes it shared between all instances of the script. Meaning, static will create the variable "score" to be shared
                            // by all objects, this way every object will not create it's own value of "score". Basically, adding all the characters points together.
    public TextMeshProUGUI scoreBoard;

    void Update()
    {
        scoreBoard.text = score.ToString(); // This will display the score. This tells the UI TextMeshPro to set the text equal to the converted string
        // of score. 
    }

    void OnTriggerEnter(Collider other) // Unity calls this
    {
        if (other.tag == "Amogu") // Then Unity calls this back
        {
            score++; // Increase the value of score by 1
            
            //Debug.Log(score);
        }
      

     //   Debug.Log("Entered");
    }// Unity knows how to call this

    

}
