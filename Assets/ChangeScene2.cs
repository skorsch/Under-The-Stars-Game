using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScene2 : MonoBehaviour {

	
	public Animator score;
	public Animator end;
	public int scene;
	
	// Use this for initialization
	public void ChangeToScene (int sceneToChangeTo) {
		
		scene = sceneToChangeTo;
		
		end.SetBool("Replay", true);
		score.SetBool("Replay", true);
		//Application.LoadLevel(sceneToChangeTo);
	}
	
	
	public void OnFadeComplete(int level){
		print(level);
		Application.LoadLevel(level);
		
	}
}
