using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coll_test : MonoBehaviour {
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    // Unity 에서 사용되는 기능들은 필요한 경우에 재정의 해서 사용한다.
    // 재정의를 안하고 있으면 엔진에서는 기본적인 처리만을 한다.

    void OnCollisionEnter(Collision collision)
    {
        print("콜라이더 충돌이 검출됨");
        print("충돌된 객체이름은 " + collision.gameObject.name);
    }

    void OnTriggerEnter(Collider other)
    {
        print("트리거 충돌이 검출됨");
        print("충돌된 객체이름은-- " + other.name + "---- " + other.gameObject.name);
    }
}



/*
 객체속성                   호출메서드
 col                        col - col
 tri                        col - tri
 col                        tri - tri
 tri                        tri - tri
 */
