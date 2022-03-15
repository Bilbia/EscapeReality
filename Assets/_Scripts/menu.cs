using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public void PlayGame()
    {
        Cursor.lockState = CursorLockMode.Locked; 
        SceneManager.LoadScene(1);
    }
    public void QuitGame(){
        Debug.Log("quit");
        Application.Quit();
    }

}