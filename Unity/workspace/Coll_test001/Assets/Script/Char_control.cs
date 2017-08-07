using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Char_control : MonoBehaviour {
    // 전역변수의 성격을 지닌 static 변수를 만든다
    // 사용은 생성영역, 변수명
    static public int count = 1;

    public float mov_rate;
    // 외부에도 볼 수 있는 권한 - 퍼블릭
    public GameObject tst1; // 일반적인 객체의 속성을 받을때
    public GameObject tst2;

    // Use this for initialization
    void Start () {
		
	}

	// Update is called once per frame
	void Update () {
        CharMove();
        Logic_check();
    }

    void Logic_check()
    {
        if (count >= 5)     // 보석을 다 떨구었을때
        {
            

            // 위에 떠있는 바닥판에 중력 적용
            Rigidbody temp = tst2.GetComponent<Rigidbody>();
            temp.useGravity = true;
        }
    }

    void CharMove()
    {
        // 객체의 이동
        // 키입력을 통한 방향을 받아야 
        float dir_x = Input.GetAxis("Vertical");
        float dir_z = Input.GetAxis("Horizontal");
        // 이동의 요소
        // 방향 * 입력방향 * 이동수치 * 프레임별 시간
        // 매 프레임별 입력 방향으로 값이 셋팅됨

        this.transform.Translate(Vector3.right * dir_x * mov_rate * Time.deltaTime);
        this.transform.Translate(new Vector3(0, 0, 1) * dir_z * mov_rate * Time.deltaTime * -1);
    }

    void OnCollisionEnter(Collision collision)
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "portal")
        {
            // 씬 이동 (scenemanager)
            SceneManager.LoadScene("Coll_test001");
        }

            print(other.gameObject.name);
        if (other.gameObject.name == "switch_01")   // 충돌객체를 체크
        {
            // 하늘에 있는 돌을 떨구기
            // 현재 this : 내 객체, 하늘의 돌 : 남의 객체
            // 남의 객체를 받는 자료형
            // GameObject   
            // 이동속성을 받는 객체
            // Tranform
            Rigidbody wall_rig;
            wall_rig = tst1.GetComponent<Rigidbody>();
            wall_rig.useGravity = true;
        }
    }
}
