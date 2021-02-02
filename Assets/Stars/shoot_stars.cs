using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot_stars : MonoBehaviour {
	
	//randomize speed???
	//public int type = 0;
	
	public float rand = 5;
	public Animator animator;
	public float xspeed = 4f;
	public float yspeed = 4f;
	private Rigidbody2D rb;
	
	public AudioSource one;
	public AudioSource two;
	public AudioSource three;
	int audioPick;
	bool played;
	
	public AudioSource click;
	
	// Use this for initialization
	void Start () {
		int score = GameObject.Find("_manager").GetComponent<ClickStar>().score;
		audioPick = Random.Range(1, 4);
		played = false;
		
		if (score > 10 ){
			xspeed = 4.5f;
			yspeed = 4.5f;
		}
		if (score > 20){
			xspeed = 4.75f;
			yspeed = 4.75f;
		}
		if (score > 30){
			xspeed = 5f;
			yspeed = 5f;
		}
		if (score > 40){
			xspeed = 5.25f;
			yspeed = 5.25f;
		}
		if (score > 50){
			xspeed = 5.5f;
			yspeed = 5.5f;
		}
		if (score > 60){
			xspeed = 5.75f;
			yspeed = 5.75f;
		}
		if (score > 70){
			xspeed = 6f;
			yspeed = 6f;
		}
		rb = this.GetComponent<Rigidbody2D>();
		rb.velocity = new Vector2(-xspeed, -yspeed);
		
		
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x < 4.0 && played == false){
			//print(audioPick);
			if (audioPick == 1){
				one.Play();
				played = true;
			}
			if (audioPick == 2){
				two.Play();
				played = true;
			}
			if (audioPick == 3){
				three.Play();
				played = true;
			}
			
		}
		
		if (transform.position.x < -6){
			Destroy(this.gameObject);
		}
	}
	
	void Explode (bool activate) {
		
		click.Play();
		rb.velocity = new Vector2(-1f,-1f);
		//print(activate);
		animator.SetBool("Clicked", activate);
	}
	
	
}
