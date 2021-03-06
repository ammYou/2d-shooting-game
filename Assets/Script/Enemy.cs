﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	Spaceship spaceship;
	// Use this for initialization
	IEnumerator Start () {
		spaceship = GetComponent <Spaceship>();
		Move (transform.up * -1);

		if (!spaceship.canShot){
			yield break;
		}
		while (true)
		{
			for (int i = 0; i < transform.childCount; i++) {
				Transform shotPosition = transform.GetChild(i);
				spaceship.Shot(shotPosition);
			}
			yield return new WaitForSeconds (spaceship.shotDelay);
		}
	}


    public void Move(Vector2 direction)
    {
        GetComponent<Rigidbody2D>().velocity = direction * spaceship.speed;
    }


    // Update is called once per frame
    void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other) {
		string layerName = LayerMask.LayerToName(other.gameObject.layer);

		if (layerName == "Bullet (Player)"){
			Destroy(other.gameObject);
			spaceship.Explosion();
			Destroy(gameObject);
		}
	}
}
