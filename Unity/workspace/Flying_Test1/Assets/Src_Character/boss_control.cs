using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class boss_control : MonoBehaviour {

    public GameObject bullet;
    public Transform firepoint;
    float firetime;
	// Use this for initialization
	void Start () {
        firetime = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (this.transform.position.x <= 18.0f)
        {
            this.transform.position = new Vector3(18.0f, this.transform.position.y, this.transform.position.z);
            Rigidbody temp = this.GetComponent<Rigidbody>();
            temp.velocity = Vector3.zero;
            GameData.isBossInfinity = false;
        }
        if(GameData.isBossInfinity == false)
        {
            // 1초마다 1번씩 발사
            // 객체생성, 물리적용
            firetime += Time.deltaTime;
            if(firetime >= 1.0f)
            {
                firetime = 0;
                // 객체생성, 물리적용
                GameObject temp = Instantiate(bullet, firepoint.position, firepoint.rotation);
                Rigidbody temp2 = temp.GetComponent<Rigidbody>();
                temp2.AddForce(firepoint.forward * 1000f);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "bullet" && GameData.isBossInfinity == false)
            GameData.m_boss_life -= 5f;
        
    }
}
