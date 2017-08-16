using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class land_scroll : MonoBehaviour {
    public float mov_rate;

	void Start () {
		
	}
	
	void Update () {
        this.transform.Translate(Vector3.back * Time.deltaTime * mov_rate);
        if (this.transform.position.z <= -600f)
        {
            this.transform.position = new Vector3(-200f, 0, 600f);
        }
	}
}
