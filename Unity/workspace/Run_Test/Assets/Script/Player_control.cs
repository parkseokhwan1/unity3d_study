using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum PlayerState { Run, Jump, D_Jump, Death }

public class Player_control : MonoBehaviour {
    public PlayerState Ps;
    public float Jump_power = 600f;

	void Start () {
		
	}
	
	void Update () {
        this.GetComponent<Rigidbody>().WakeUp();    // 물리성질 한번 충돌체크한 후에
        // 자동적으로 슬립형태로 빠진다( 충돌처리횟수를 자동으로 최적화)
        // 강제로 슬립형태를 깨우는 방식으로 물리 처리 => 누락되는 충돌체크가 사라짐.
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            if (this.Ps == PlayerState.Jump) { D_Jump(); }
            if  (this.Ps == PlayerState.Run) { Jump();   }
        }	
	}

    void Jump()
    {
        Ps = PlayerState.Jump;
        this.GetComponent<Rigidbody>().AddForce(Vector3.up * Jump_power);
    }

    void D_Jump()
    {
        Ps = PlayerState.D_Jump;
        this.GetComponent<Rigidbody>().AddForce(Vector3.up * Jump_power);
    }

    void Death()
    {
        Ps = PlayerState.Death;
    }

    void Run()
    {
        Ps = PlayerState.Run;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (this.Ps != PlayerState.Run) { Run(); }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Coin")
        {
            Destroy(other.gameObject);
        }
    }
}
