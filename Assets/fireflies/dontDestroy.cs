using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontDestroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		 GameObject[] objs = GameObject.FindGameObjectsWithTag("fireflies");

        if (objs.Length > 3)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
