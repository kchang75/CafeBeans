using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CycleSprite : MonoBehaviour
{
	public Sprite[] frames;
	private SpriteRenderer sr;
	int frameCount, currentFrame;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        frameCount = frames.Length;
        currentFrame = 0;
        sr.sprite = frames[currentFrame];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
    	if (currentFrame < frames.Length)
    	{
    		currentFrame++;
    		if (currentFrame == frames.Length)
    		{
    			currentFrame = 0;
    		}
    		sr.sprite = frames[currentFrame];
    	}
    }
}
