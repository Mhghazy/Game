//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {

    // Use this for initialization
    /*
	void Start () {
		
	}
    */

    // Update is called once per frame

    public Transform player;
    public Text scoreText;

	void Update () {
        scoreText.text = player.position.z.ToString("0");
		
	}
}
