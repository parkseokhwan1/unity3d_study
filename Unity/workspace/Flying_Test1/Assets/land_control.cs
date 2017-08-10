using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class land_control : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(this.gameObject.name == "badak")
        {
            if(other.name == "player")
            {
                print("바닥에 충돌");
                //GameData.hp = 0f;
                //GameData.state = gameover;
                //Play, over, pause
            }
        }    
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "player")
        {
            print("건물에 충돌 => " + this.gameObject.name);
            //GameData.hp -= 10f;
            BoxCollider bc = collision.gameObject.GetComponent<BoxCollider>();

            bc.isTrigger = true;
        }
    }
}
