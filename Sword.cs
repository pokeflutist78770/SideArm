using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter(Collider other) {
		print("Sword Collision");
		//Destroy(other.gameObject);
		if (other.transform.root.gameObject.CompareTag("Enemy")) {

			print("Enemy Collided");
			other.transform.root.gameObject.GetComponent<Animator>().enabled = false;
		}

	}
}
