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

	private void FixedUpdate() {
		print(transform.root.gameObject.GetComponent<Rigidbody>().velocity);
	}

	private void OnTriggerEnter(Collider other) {
		print("Sword Collision");
		//Destroy(other.gameObject);
		if (other.transform.root.gameObject.CompareTag("Enemy")) {

			print("Enemy Collided");
			other.transform.root.gameObject.GetComponent<Animator>().enabled = false;
		}
		else if (other.gameObject.CompareTag("Wall")) {
			other.transform.root.gameObject.GetComponent<PlayerController>().health -= 5;

		}

	}

	private void OnCollisionEnter(Collision other) {
		print("Sword Collision");
		//Destroy(other.gameObject);
		if (other.transform.root.gameObject.CompareTag("Enemy")) {

			print("Enemy Collided");
			other.transform.root.gameObject.GetComponent<Animator>().enabled = false;

			Vector3 velocity = this.transform.root.gameObject.GetComponent<Rigidbody>().velocity;

			other.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3((velocity.x*5), 10, (velocity.z*5)), ForceMode.Impulse);

			//this.transform.root.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 1, 0), ForceMode.VelocityChange);
			/*
			Collider[] colliders = Physics.OverlapSphere(explosionPos, radius);
			foreach (Collider hit in colliders) {
				print(hit.gameObject.tag);
				
				Rigidbody rb = hit.GetComponent<Rigidbody>();

				if (rb != null && rb.gameObject.tag!="Player")
					rb.AddExplosionForce(power, explosionPos, radius, 200.0F);
				
			}
			*/
		}
		else if (other.gameObject.CompareTag("Wall")) {
			this.transform.root.gameObject.GetComponent<PlayerController>().health -= 5;

		}

	}
}
