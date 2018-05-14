using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyArea : MonoBehaviour {

	void OnTriggerExit2D(Collider2D other) {
		Destroy(other.gameObject);
		//Destroy(other.gameObject.transform.parent.gameObject);
		
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
