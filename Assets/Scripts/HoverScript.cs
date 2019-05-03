using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverScript : MonoBehaviour
{
	private SpriteRenderer sr;
	public string PickColor;

	void Start()
	{
		sr = GetComponent<SpriteRenderer>();
	}

    void OnMouseOver()
    {
        //If your mouse hovers over the GameObject with the script attached, output this message
        Debug.Log("Mouse is over GameObject.");
        
        if (PickColor == "yellow")
        {
        	sr.color = Color.yellow;
        }
        else if (PickColor == "cyan")
        {
        	sr.color = Color.cyan;
        }

    }

    void OnMouseExit()
    {
        //The mouse is no longer hovering over the GameObject so output this message each frame
        Debug.Log("Mouse is no longer on GameObject.");
        sr.color = Color.white;

    }

}
