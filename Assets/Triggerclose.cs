using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggerclose : MonoBehaviour {

	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void OnFadeComplete(){
		GameObject man = GameObject.Find("_manager");
		
		man.BroadcastMessage("OnFadeComplete", 1);
	}
}
