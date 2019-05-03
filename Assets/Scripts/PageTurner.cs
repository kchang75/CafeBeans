using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PageTurner : MonoBehaviour
{
    public string pointing;
    public GameObject[] screens;
    private SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
		sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
    	if (pointing == "left")
    	{
    		for (int i = 0; i < screens.Length; i++){
    			screens[i].transform.Translate(18,0,0);
    		}
    	}
    	else if (pointing == "right")
    	{
    		for (int i = 0; i < screens.Length; i++){
    			screens[i].transform.Translate(-18,0,0);

    		}
    	}
    }
}
