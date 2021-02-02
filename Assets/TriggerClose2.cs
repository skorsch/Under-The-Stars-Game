using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerClose2 : MonoBehaviour {

	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void OnFadeComplete(){
		GameObject man = GameObject.Find("_manager");
		int scene = man.GetComponent<ChangeScene2>().scene;
		man.BroadcastMessage("OnFadeComplete", scene);
	}
}


