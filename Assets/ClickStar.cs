using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickStar : MonoBehaviour {
	public int score;
	public Text scoretext;
	private GameObject scorestar;
	
	int bigstars;
	public Text bigST;
	//public AudioSource play;

	// Use this for initialization
	void Start () {
		score = 0;
		bigstars = 0;
		scoretext.text = score.ToString();
		scorestar = GameObject.Find("scorestar2");
	}
	
	// Update is called once per frame
	void Update () {
		int totalscore = score + bigstars;
		bigST.text = "Total + Bonus Stars = " + totalscore.ToString();
		//if left click
		if (Input.GetMouseButtonDown(0))
		{
		
		Collider2D hit = Physics2D.OverlapPoint(Camera.main.ScreenToWorldPoint(Input.mousePosition));
		
		
		
		if (hit)
		{
			print("hit!");
			
			GameObject clicked = hit.gameObject;
			
			//animation trigger
			clicked.BroadcastMessage("Explode", true);
			Destroy(clicked.GetComponent<Collider2D>());
			//Destroy(clicked);
			score++;
			scoretext.text = score.ToString();
			
		}
		else {
			//print("miss");
		}
		}
		if (score%10 == 0 && score != 0){
			//print("10");
		scorestar.BroadcastMessage("Trigger", true);
		}
		else {
			scorestar.BroadcastMessage("Trigger", false);
		}
		
	}
	public void BigStar (){
		bigstars++;
	}
}
