using UnityEngine;
using System.Collections;
using System;

public class player : MonoBehaviour {

    private int score = 0;
    private float stamina = 0;
    private float currentSpeed = speed;

    private const float speed = 1;
    private const float runningSpeed = 1.6f;
    private const int maxStamina = 10;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        //movement input
        if (Input.GetButton("d")) {
            transform.position = new Vector3(transform.position.x + (currentSpeed * Time.deltaTime), transform.position.y, transform.position.z);
        }
        if (Input.GetButton("a")) {
            transform.position = new Vector3(transform.position.x - (currentSpeed * Time.deltaTime), transform.position.y, transform.position.z);
        }
        if (Input.GetButton("w")) {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + (currentSpeed * Time.deltaTime));
        }
        if (Input.GetButton("s")) {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - (currentSpeed * Time.deltaTime));
        }

        //Stamina / Running
        if (Input.GetButton("LShift")) {
            if (stamina > 0) {
                currentSpeed = runningSpeed;
                stamina -= 3 * Time.deltaTime;
            }
        } else {
            if (stamina < 10) stamina += 1 * Time.deltaTime;
            if (stamina > 10) stamina = 10;
            currentSpeed = speed;
        }

        //handshaking (Space)
            //need sprite with animation
        //reseting if your hand was shaken
            //need random spawn location
    }

    //also need score board for end of game and time keeping for match length
    // handle enableing / disable scripts for multiplayer
}
