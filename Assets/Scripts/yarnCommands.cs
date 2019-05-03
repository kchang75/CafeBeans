using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Yarn.Unity;

public class yarnCommands : MonoBehaviour {
	
	public GameObject Gwen;
	public GameObject Mike;
	public GameObject Richard;
	public GameObject Willow;


	// <<showGwen>>
	[YarnCommand("showGwen")]
	public void ShowGwen(){
		// show character
		Gwen.SetActive(true);
	}

	// <<hideGwen>>
	[YarnCommand("hideGwen")]
	public void HideGwen(){
		// hide character
		Gwen.SetActive(false);
	}

	// <<showMike>>
	[YarnCommand("showMike")]
	public void ShowMike(){
		// show character
		Mike.SetActive(true);
	}

	// <<hideMike>>
	[YarnCommand("hideMike")]
	public void HideMike(){
		// hide character
		Mike.SetActive(false);
	}

	// <<showRichard>>
	[YarnCommand("showRichard")]
	public void ShowRichard(){
		// show character
		Richard.SetActive(true);
	}

	// <<hideRichard>>
	[YarnCommand("hideRichard")]
	public void HideRichard(){
		// hide character
		Richard.SetActive(false);
	}

	// <<showWillow>>
	[YarnCommand("showWillow")]
	public void ShowWillow(){
		// show character
		Willow.SetActive(true);
	}

	// <<hideWillow>>
	[YarnCommand("hideWillow")]
	public void HideWillow(){
		// hide character
		Willow.SetActive(false);
	}

	// <<LoadScene CoffeeMinigame>>
	[YarnCommand("LoadScene")]
	public void LoadScene(string sceneName){
		SceneManager.LoadScene(sceneName);
	}

	
}
