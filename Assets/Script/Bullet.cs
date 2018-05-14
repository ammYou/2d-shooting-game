using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
	public int speed = 10;
	public float leftTime = 5.0f;
	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D>().velocity = transform.up.normalized * speed;

		Destroy(gameObject, leftTime);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	
}
