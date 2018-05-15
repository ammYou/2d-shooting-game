using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Spaceship : MonoBehaviour {
	public float speed;//move speed
	public float shotDelay;//shot time
	public GameObject bullet;
	public GameObject explosion;
	public bool canShot;

	public void Explosion(){
		Instantiate (explosion, transform.position, transform.rotation);
	}

	public void Shot (Transform origin){
		Instantiate (bullet, origin.position, origin.rotation);//create shot object
	}


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
