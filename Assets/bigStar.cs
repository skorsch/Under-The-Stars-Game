using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bigStar : MonoBehaviour {

	//public int type = 1;

	public Animator animator;
	public float x = 4f;
	public float y = 4f;
	private Rigidbody2D rb;
	
	public int bigHit;
	
	public AudioSource one;
	bool played;
	
	public AudioSource click;
	
	// Use this for initialization
	void Start () {
		played = false;
		
		rb = this.GetComponent<Rigidbody2D>();
		rb.velocity = new Vector2(-x, -y);
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x < 4.0 && played == false){
			one.Play();
			played = true;
		}
		if (transform.position.x < -6){
			Destroy(this.gameObject);
		}
	}
	//referenced in spawn?
	void Explode (bool activate) {
		
		GameObject.Find("_manager").BroadcastMessage("BigStar");
		click.Play();
		rb.velocity = new Vector2(-1f,-1f);
		//print(activate);
		animator.SetBool("Clicked", activate);
	}
	
	
}
