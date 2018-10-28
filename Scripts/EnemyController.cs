using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {
	public int speed;
	public bool isAlive;
	public AudioClip death;

	// Use this for initialization
	void Start () {
		speed = 1;
	}
	
	// Update is called once per frame
	void Update () {
		if (isAlive) {
			//transform.Rotate(new Vector3(speed * 15 * Time.deltaTime, speed * 30 * Time.deltaTime, speed * 45 * Time.deltaTime));
		}
      
	}

}
