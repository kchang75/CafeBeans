using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PumpController : MonoBehaviour
{

    public float speed = 2;
    bool clicked, goingDown, goingUp;
    private float startingY;


    // Start is called before the first frame update
    void Start()
    {
    	startingY = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
        	clicked = true;
        	goingDown = true;
        }

        if (clicked)
        {
        	if (goingDown)
			{
				transform.Translate (Vector2.down * speed * Time.deltaTime);
				if (startingY - transform.position.y < 0)
				{
					goingUp = true;
					goingDown = false;
				}
			}
			else if (goingUp)
			{
				transform.Translate (Vector2.up * speed * Time.deltaTime);
				if (startingY - transform.position.y > 2)
				{
					goingUp = false;
				}
			}
			else
			{
				clicked = false;
			}
        }
    }


}
