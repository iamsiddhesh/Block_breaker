using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LoseCollider : MonoBehaviour {

	private LevelManager levelManager;

	void OnTriggerEnter2D (Collider2D trigger){
		levelManager = FindObjectOfType<LevelManager> (); 	
		levelManager.LoadLevel ("loose");
	}
	
	// Update is called once per frame
	void OnCollisionEnter2D (Collision2D collision) {
		print("Collision");
	}
}
