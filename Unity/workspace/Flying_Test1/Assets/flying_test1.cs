using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flying_test1 : MonoBehaviour {
    public float mov_val;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Translate(new Vector3(0,1,0) * Time.deltaTime * mov_val);


	}
}
