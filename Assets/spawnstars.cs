using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spawnstars : MonoBehaviour {

	public GameObject starPrefab;
	public GameObject starPrefab2;
	public float respawnTime = 1.0f;
	private int score;
	
	private IEnumerator startcount;
	private IEnumerator coroutine;
	private bool isWaveDone;
	
	public Animator points;
	public Animator endscreen;
	
	//stars missed
	public Text missed;
	int stars;
	
	//big star spawnstar
	int ran;
	bool first = true;
	bool second = true;
	bool third = true;
	bool fourth = true;
	bool fifth = true;
	
	// Use this for initialization
	void Start () {
		//for big stars
		ran = Random.Range(-5, 5);
		
		stars = 0;
		isWaveDone = false;
		coroutine = starWave();
		startcount = startCount();
		StartCoroutine(startcount);
		StartCoroutine(coroutine);
	}
	private void spawnShoot (){
		GameObject a = Instantiate(starPrefab) as GameObject;
		//add random x values
		a.transform.position = new Vector2 (Random.Range(-2.0f, 8.5f), 5.5f);
	}
	
	private void spawnShoot2 (){
		GameObject b = Instantiate(starPrefab2) as GameObject;
		//add random x values
		b.transform.position = new Vector2 (Random.Range(0f, 6f), 5.5f);
	}
	
	IEnumerator startCount(){
		while(true){
			//CHANGE AFTER TEST
			yield return new WaitForSeconds(90f);
			StopCoroutine(coroutine);
			isWaveDone = true;
		}
	}
			
	
	IEnumerator starWave(){
		while (true){
			score = GameObject.Find("_manager").GetComponent<ClickStar>().score;
		
			if (score > 10 ){
				respawnTime = 0.80f;
				
			}
			if (score > 20){
				respawnTime = 0.60f;
				
			}
			if (score > 30){
				respawnTime = 0.50f;
				
			}
			if (score > 40){
				respawnTime = 0.40f;
				
			}
			if (score > 50){
				respawnTime = 0.30f;
				
			}
			if (score > 60){
				respawnTime = 0.20f;
				
			}
			yield return new WaitForSeconds(respawnTime*Random.Range(0.5f, 1.5f));
		spawnShoot();
		stars++;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (first == true && 20 + ran <= score){
			spawnShoot2();
			first = false;
			stars++;
		}
		if (second == true && 40 + ran <= score){
			spawnShoot2();
			second = false;
			stars++;
		}
		if (third == true && 60 + ran <= score){
			spawnShoot2();
			third = false;
			stars++; 
		}
		if (fourth == true && 80 + ran <= score){
			spawnShoot2();
			stars++;  
			fourth = false;
		}
		if (fifth == true && 100 + ran <= score){
			spawnShoot2();
			stars++; 
			fifth = false;
		}
			
		if (isWaveDone){
			//print("final score!" + score);
			points.SetBool("out", true);
			endscreen.SetBool("in", true);
			int starsMissed = stars - score;
			missed.text = starsMissed.ToString();
		}
	}
	
		
}
