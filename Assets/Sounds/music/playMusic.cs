using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playMusic : MonoBehaviour {

	public AudioSource start;
	public AudioSource a;
	public AudioSource b;
	public AudioSource c;
	public AudioSource d;
	public AudioSource e;
	public AudioSource f;
	public AudioSource g;
	public AudioSource h;
	
	private int score;
	
	// Use this for initialization
	void Start () {
		start.volume = 0.0f;
		a.volume = 1.0f;
		b.volume = 0.0f;
		c.volume = 0.0f;
		d.volume = 0.0f;
		e.volume = 0.0f;
		f.volume = 0.0f;
		g.volume = 0.0f;
		h.volume = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		score = GameObject.Find("_manager").GetComponent<ClickStar>().score;
		//print(start.time);
		//if (start.time >= 1.538f){
			//a.Play();
			//b.Play();
			//c.Play();
			//d.Play();
			//e.Play();
			//f.Play();
			//g.Play();
			//h.Play();
		//}
		if (score == 5){
			StartCoroutine(FadeIn(b));
			//b.volume = 1f;
		}
		//CHANGE AFTER
		if (score == 10){
			StartCoroutine(FadeIn(c));
			//c.volume = 1f;
		}
		if (score == 15){
			StartCoroutine(FadeIn(d));
			//d.volume = 1f;
		}
		if (score == 20){
			StartCoroutine(FadeIn(e));
			//e.volume = 1f;
		}
		if (score == 25){
			StartCoroutine(FadeIn(f));
			//f.volume = 1f;
		}
		if (score == 35){
			StartCoroutine(FadeIn(g));
			//g.volume = 1f;
		}
		if (score == 45){
			StartCoroutine(FadeIn(h));
			//h.volume = 1f;
		}
			
	}
	IEnumerator FadeIn (AudioSource current){
		while (current.volume < 1.0f){
			current.volume += Time.deltaTime / 20f;
			yield return null;
			
			
		}
			
	}
}
