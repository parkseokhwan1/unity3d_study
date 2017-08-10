using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_control : MonoBehaviour {
    float timedata;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if(this.transform.position.x >= 20.0f)
        {
            Destroy(this.gameObject);
        }
        timedata += Time.deltaTime;
        if (timedata >= 1.0f)
        {
            timedata = 0;
            Destroy(this.gameObject);
        }
    }
}
