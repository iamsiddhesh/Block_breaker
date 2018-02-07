using System.Collections;
using System.Collections.Generic;	
using UnityEngine;
	
 	public class Ball : MonoBehaviour {
	
	private Paddle paddle; // getting access to paddle script.
	private bool hasStarted= false;
	private Vector3 paddleToBallVector;// declaring variable for storing paddle to ball vector

	// Use this for initialization
	void Start () {
		paddle = GameObject.FindObjectOfType<Paddle>();
		paddleToBallVector = this.transform.position - paddle.transform.position;// calculating the difference 
		}
	
	// Update is called once per frame
	void Update () {
		if(!hasStarted ){
			//lock the ball relative to the paddle
		this.transform.position = paddle.transform.position + paddleToBallVector;
		   //wait for mouse press to launch
		
		if (Input.GetMouseButtonDown (0)) {   // returns the mouse is clicked
			hasStarted = true;
			this.GetComponent<Rigidbody2D>().velocity = new Vector2 (2f, 10f);//
		}
		}
	}
	void OnCollisionEnter2D (Collision2D collision) {
		Vector2 tweak = new Vector2(Random.Range(0f, 0.2f),Random.Range(0f, 0.2f));

		if (hasStarted) {
			if(collision.gameObject.name != "Brick") {
				gameObject.GetComponent<AudioSource>().Play();
			}
		gameObject.GetComponent<AudioSource> ().Play ();
			GetComponent<Rigidbody2D> ().velocity += tweak;
		}
	}

}
