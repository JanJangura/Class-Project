using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Allow the functions in Unity to change scenes

public class MainMenuScript : MonoBehaviour
{
    // A function, can be looked as an formula or equation. can look like f(x) = 1 + 1;
    // The header of a function NEVER has a semicolon in it
    // This function takes no arguments/parameters but you must still include the parantheses!
    public void ExitGame(){ // The public term will allow the function to be visible
        Debug.Log("Quitted");
        Application.Quit();


    }// Every { must have a } to match it



    // We added a string argument to this one, so it can be reused for other scenes
    public void LoadLevel(string sceneName) {    // Basically f(x) = x + 1  --- We are changing the x component
        //We now have a function that can load a scene
        SceneManager.LoadScene(sceneName); // 
    }



}
