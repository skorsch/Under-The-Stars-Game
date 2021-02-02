using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setres : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//pc
		Screen.SetResolution(800,1000,false);
		if (Screen.height < 1000){
			Screen.SetResolution (560,700,false);
		}
		//Screen.SetResolution(800,1000,false);
		//if (Screen.width < 800){
		//	Screen.SetResolution (720,900,false);
		//}
		//if (Screen.width < 720){
		//	Screen.SetResolution(640,800,false);
		//}
		//if (Screen.width < 640){
		//	Screen.SetResolution(480,600,false);
		//}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
