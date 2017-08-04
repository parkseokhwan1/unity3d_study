using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chr_old : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(this.transform.position.y <= 1.0f)       // transform 외에 객체는 추가객체(component)
        {
            Rigidbody temp
                = this.GetComponent<Rigidbody>();
            temp.useGravity = false;
            temp.velocity = Vector3.zero;
        }

        // 물리 , 중력 해제
	}
}
