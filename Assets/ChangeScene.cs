using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScene : MonoBehaviour {
	
	public GameObject panel;
	public Animator animator;
	// Use this for initialization
	public void ChangeToScene (int sceneToChangeTo) {
		//print("gotem");
		panel = GameObject.Find("Panel");
		Destroy(panel);
		animator.SetBool("fade", true);
		//Application.LoadLevel(sceneToChangeTo);
	}
	
	public void OnFadeComplete(int level){
		Application.LoadLevel(level);
		
	}
		
	
}
