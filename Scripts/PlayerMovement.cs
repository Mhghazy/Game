using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    public float backwardForce = 10000f;

    public Joystick joystick;

     

	// Use this for initialization
    /*
	void Start ()
    {
        rb.AddForce(0,200,100);
        
	}
	*/

	// Update is called once per frame
    // are using it to mess with the physics
	void FixedUpdate ()
    {
        //Add a forward Force
        rb.AddForce(0,0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
        {
            //Only executed if the condition is met
            rb.AddForce(sidewaysForce * Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        else if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
        {
            //Only executed if the condition is met
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        else if (Input.GetKey("s") || Input.GetKey(KeyCode.DownArrow))
        {
            //Only executed if the condition is met
            rb.AddForce(0, 0, -backwardForce * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (joystick.Horizontal >= .3f)
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }else if (joystick.Horizontal <= -.3f)
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        else if (joystick.Vertical <= -.3f)
        {
            rb.AddForce(0, 0, -backwardForce * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

        if (Input.GetKey("q")|| Input.GetKey(KeyCode.Escape))
        {
            Debug.Log("Quit");
            Application.Quit();
        }
        
    }
}
