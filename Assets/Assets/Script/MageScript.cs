using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MageScript : MonoBehaviour {
    public Rigidbody2D rb;           //declare rigidbody
	public Animator animator;
   // public bool x;


	// Use this for initialization
	void Start() 
	{
		rb = GetComponent<Rigidbody2D>();          //initialize rigidbody
        rb.MovePosition(new Vector2(-115, 0));     //sets mage to (-150, 0), middle of wall, when game starts
    }
	
	// Update is called once per frame
	void Update() 
	{
        if (Input.GetMouseButton(0) && Camera.main.ScreenToWorldPoint(Input.mousePosition).y > 0 && rb.position.y < 70 && Camera.main.ScreenToWorldPoint(Input.mousePosition).x < -96)  //if mouse is in clicked and mouse
        {											      //is above half-screen and mage is not at top of screen
           rb.velocity = (new Vector2(0, 100));	                                              //sets mage velocity to 100 upwards
		   animator.SetFloat("Speed", 100);
        }
        else if(Input.GetMouseButton(0) && Camera.main.ScreenToWorldPoint(Input.mousePosition).y < 0 && rb.position.y > -70 && Camera.main.ScreenToWorldPoint(Input.mousePosition).x < -96)   //if mouse is clicked and mouse is below
        {												     //half-screen and mage is not at bottom of screen
            rb.velocity = (new Vector2(0, -100));                                                        //sets mage velocity to 100 downwards
			animator.SetFloat("Speed", -100);
        }
        else
        {
            rb.velocity = (new Vector2(0, 0));   //sets mage velocity to 0
			animator.SetFloat("Speed", 0);
        }
		
		
	}
}
