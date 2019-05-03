using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public void LoadMenu(){
    	SceneManager.LoadScene("MenuScene");
    }

    public void LoadGame(){
    	SceneManager.LoadScene("MainGame");
    }

    public void LoadCredits(){
    	SceneManager.LoadScene("CreditsScene");
    }

    public void QuitGame(){
    	Application.Quit();
    }
}
