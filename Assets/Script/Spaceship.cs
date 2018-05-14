using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaceship : MonoBehaviour {
	public float speed;//move speed
	public float shotDelay;//shot time
	public GameObject bullet;
	public bool canShot;

	public void Shot (Transform origin){
		Instantiate (bullet, origin.position, origin.rotation);//create shot object
	}

	public void Move (Vector2 direction){
		GetComponent <Rigidbody2D>().velocity = direction * speed;//Moce object
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
