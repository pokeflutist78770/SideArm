using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public Collider MainCollider;
    public Collider[] AllColliders;

	// Use this for initialization
	void Awake () {
        MainCollider = GetComponent<Collider>();
        AllColliders = GetComponentsInChildren<Collider>(true);
        DoRagdoll(false);
	}
	
	// Update is called once per frame
	public void DoRagdoll (bool isRagDoll) {

       
        }

        //foreach (var col in AllColliders)
        //    col.enabled = isRagDoll;
        //MainCollider.enabled = !isRagDoll;
        //<Rigidbody>().useGravity = !isRagDoll;
        //GetComponent<Animator>().enabled = !isRagDoll;
    }
