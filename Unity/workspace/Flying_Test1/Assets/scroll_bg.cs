using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scroll_bg : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(this.transform.position.x >= -42f)
        this.transform.Translate(Vector3.left * Time.deltaTime * 1.5f);
	}
}
