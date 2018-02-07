using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Brick : MonoBehaviour {
	public AudioClip hit;
	public Sprite[] hitsprites;
	private int timesHit;
	private LevelManager levelManager;
	public static int breakableCount = 0;
	private bool isBreakable;

	// Use this for initialization
	void Start () {
		isBreakable = (this.tag == "Breakable");
		if (isBreakable) {//keep track of breakable breaks
			breakableCount ++;

		}// condition for unbreakable brick
		timesHit  = 0;
		levelManager = GameObject.FindObjectOfType<LevelManager>();
 		
		}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter2D(Collision2D col){
		AudioSource.PlayClipAtPoint (hit, transform.position);
		if (isBreakable) {
			Handlehits ();
		}
	}
	void Handlehits(){
		timesHit++;
		int maxHits = hitsprites.Length + 1;
		if (timesHit == maxHits) {
			breakableCount --;
			levelManager.BrickDestroyed ();
			Destroy (gameObject);
		} else {
			LoadSprites ();
		}
	
	
	}
	void LoadSprites(){
		int spriteIndex = timesHit - 1;
		if (hitsprites [spriteIndex]) {
			this.GetComponent<SpriteRenderer> ().sprite = hitsprites [spriteIndex];
		}
	}
	//TODO Remove this method once we actuallywin!
	void SimulateWin(){
		levelManager.LoadNextLevel ();
	}

}

