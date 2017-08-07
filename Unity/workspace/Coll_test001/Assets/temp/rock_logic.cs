using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rock_logic : MonoBehaviour {
    Rigidbody ph;

	// Use this for initialization
	void Start () {
        ph = this.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        // 2)
        // if (test_capsule.states == true)
        // ph.useGravity = true;
        // 3)
        ph.useGravity = true;

    }
}
