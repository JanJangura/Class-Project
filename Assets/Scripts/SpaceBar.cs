using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEditor.Rendering;

public class SpaceBar : MonoBehaviour
{
    public TextMeshProUGUI testingText; // This will record the frames and display in Game.
    public KeyCode testingKey; // Basically pressing this button will activate something. But we are using this variable to 
    // record the logs or tests.

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(testingKey)) // The first frame of when the button is pressed .... It's very fast! So you prolly won't be able to see it.
        {
            testingText.text = "";
            testingText.color = Color.red;
            // To change the color ---> testingText.color = Color.red;
            // Debug.Log("Down");
        }
        else if (Input.GetKey(testingKey))
        {
            testingText.text = "Space Bar Pressed";
            testingText.color = Color.blue;
            // To change the color ---> testingText.color = Color.magneta;
            // Debug.Log("Hold");
        }
        else if (Input.GetKeyUp(testingKey)) // 
        {
            testingText.text = "Space Bar Not Pressed";
            testingText.color = Color.red;
            // testingText.color = color.yellow;
            // For more extreme colors --->  testingText.color = new Color(0.6f, 0.3f, 0.
            // Debug.Log("Up");
        }
    }
}
