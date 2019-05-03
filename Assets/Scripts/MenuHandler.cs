using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuHandler : MonoBehaviour
{
    public GameObject menuObject;

    public void openMenu(){
    	menuObject.SetActive(true);
    }

    public void closeMenu(){
    	menuObject.SetActive(false);
    }
}
