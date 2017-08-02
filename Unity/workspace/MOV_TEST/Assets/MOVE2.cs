using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOVE2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Translate(Vector3.forward * 0.02f);
    }
}
