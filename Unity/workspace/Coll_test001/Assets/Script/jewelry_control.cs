using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jewelry_control : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		

        // 떨어진다 => 일정 높이보다 아래다
        if (this.transform.position.y < -5f)
        {
            print(Char_control.count);
            //Char_control.count += 4;
            Char_control.count++;
            //Destroy(this.gameObject);
            DestroyObject(this.gameObject);
        }
	}
}
