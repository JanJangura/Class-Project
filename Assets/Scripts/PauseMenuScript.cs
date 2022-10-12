using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEditor.Rendering;

public class PauseMenuScript : MonoBehaviour
{
    public GameObject menu; // This is a game object called menu. GameObject will be found by name and return it.
    public TextMeshProUGUI testingText; // This will record the frames and display in Game.
    public KeyCode testingKey; // Basically pressing this button will activate something. But we are using this variable to 
    // record the logs or tests.
    public bool isPaused = false;


    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        menu.SetActive(false); //
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(testingKey)) // The first frame of when the button is pressed .... It's very fast! So you prolly won't be able to see it.
        {
            testingText.text = "Down"; 
            testingText.color = Color.red;
            // To change the color ---> testingText.color = Color.red;
            // Debug.Log("Down");
        }
        else if (Input.GetKey(testingKey))
        {
            testingText.text = "Hold";
            testingText.color = Color.blue;
            // To change the color ---> testingText.color = Color.magneta;
            // Debug.Log("Hold");
        }
        else if (Input.GetKeyUp(testingKey)) // 
        {
            testingText.text = "Up";
            testingText.color = Color.yellow;
            // testingText.color = color.yellow;
            // For more extreme colors --->  testingText.color = new Color(0.6f, 0.3f, 0.
            // Debug.Log("Up");
        }
        else
        {
            // Nothing here
            // This would be every frame the key is not pressed
        }
        

        if (Input.GetButtonDown("Cancel"))
        {
            TogglePauseGame();
        }
    }

    public void TogglePauseGame()
    {
        // Will only open menu
        isPaused = !isPaused;

        // menu.SetActive(true);
        //menu.SetActive(!menu.activeInHierarchy); // Where a subject is active
        menu.SetActive(isPaused);

        if (isPaused)
        {
            Time.timeScale = 0f; // A global variable 
        }
        else
        {
            Time.timeScale = 1f;
        }
        // We're not stopping the data or instructions the jumpForce is recieving, we're only stopping time.
    }

    public void LoadLevel(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }


}

// *****TO SUBMIT ASSIGNMENT 3 IN GAME DEV.*****
// File >> Build Settings >> Build, then build into the Build Folder and then call it 1stbuild. Once the Files have been built, compress all 
// the files into a zip file. Then turn in the zipped file.