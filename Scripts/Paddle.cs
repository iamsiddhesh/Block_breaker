using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {
	public bool autoPlay = false;
	private Ball ball;
	

	// Use this for initialization
	void Start () {
		ball = GameObject.FindObjectOfType<Ball> ();

	}

	// Update is called once per frame
	void Update () {
		if (!autoPlay) {
			MoveWithTheMouse ();
		} else {
			Autoplay ();
		}
	}
	void Autoplay(){
		Vector3 paddlePos = new Vector3 (0.0f,this.transform.position.y, 0);
		Vector3 ballPos =ball.transform.position;
		paddlePos.x = Mathf.Clamp(ballPos.x, 0.503f, 15.49f);
		this.transform.position = paddlePos;
		
	}
	void MoveWithTheMouse(){
		Vector3 paddlePos = new Vector3 (0.0f,this.transform.position.y, 0);
		float mousePosInBlocks = Input.mousePosition.x / Screen.width * 16;
		paddlePos.x = Mathf.Clamp(mousePosInBlocks, 0.503f, 15.49f);
		this.transform.position = paddlePos;
	}
}
