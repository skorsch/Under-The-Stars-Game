using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopCrickets : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject[] objs = GameObject.FindGameObjectsWithTag("backgroundnoise");
		if(objs.Length>1){
			Destroy(this.gameObject);
		}
		DontDestroyOnLoad(this.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
