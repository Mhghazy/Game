//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    // Use this for initialization
    /*
	void Start () {
		
	}

	
	// Update is called once per frame
	void Update () {
		
	}
    */

    public PlayerMovement movement;
    public GameManager gameManager;

    void OnCollisionEnter(Collision collisionInfo)
    {
        

        if (collisionInfo.collider.tag == "Obsticale")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
