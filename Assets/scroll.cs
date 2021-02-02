using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scroll : MonoBehaviour {

	float scrollspeed = -0.25f;
	Vector2 startPos;
	
	// Use this for initialization
	void Start () {
		startPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		float newPos = Mathf.Repeat (Time.time * scrollspeed, 10);
		transform.position = startPos + (Vector2.right + Vector2.up) * newPos;
	}
}
