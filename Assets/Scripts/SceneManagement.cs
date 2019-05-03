using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public void LoadMenu(){
    	SceneManager.LoadScene("MenuScene");
    }

    public void LoadGallery(){
    	SceneManager.LoadScene("ArtGallery");
    }

    public void LoadGame(){
        SceneManager.LoadScene("Main_Test");
    }

    public void LoadCoffee(){
        SceneManager.LoadScene("CoffeeMiniGame");
    }

    public void LoadCredits(){
    	SceneManager.LoadScene("CreditsScene");
    }

    public void QuitGame(){
    	Application.Quit();
    }
}
