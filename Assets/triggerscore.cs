﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerscore : MonoBehaviour {

	public Animator animator;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void Trigger (bool score){
		animator.SetBool("score",score);
	}
}
