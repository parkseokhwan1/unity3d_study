using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOVE : MonoBehaviour {
    public float speed;                         // public으로 선언시 외부에서 볼수있음(unity), private 으로 선언시 소스코드내부에서만 
                                                // 자료형을 만들고 아무것도 셋팅안하면 기본값 0임
    // float ret = 0;
    float elapedtime;
    int count;
    int fps;

    private void Awake()                        // 생성시 셋팅       순서. 1) 유니티외부, public 객체 표시부 2) Awake 3) Start 순으로 값이 셋팅됨
    {
        speed = 5.0f;
        elapedtime = 0;
        count = 0;
        fps = 0;
    }
    
    // Use this for initialization
    void Start () {                             // unity에서 실행후 실행 (private), 생성 이후에 셋팅
        
	}
	
	// Update is called once per frame
	void Update () {
        // 시간값 얻어오기
        //Time.deltaTime // 프레임별 시간             // 1초당 이동거리 : 거리 X Time.deltaTime

        // 키 입력
        // input : 다양한 입력에 관련된 기능이 정의되어 있음

        float ret2 = Input.GetAxis("Horizontal");    // 유니티 엔진의 axis로 정의된 키셋팅을 얻어옴
        float ret = Input.GetAxis("Vertical");
        //this.transform.Translate(new Vector3(0, 0, 1) * speed * ret);         // speed (* ret)
        //this.transform.Translate(new Vector3(1, 0, 0) * speed * ret2);    

        //this.transform.Translate(Vector3.forward * speed * ret);
        //this.transform.Translate(Vector3.right * speed * ret2);

        //this.transform.Translate(new Vector3(1 * ret2, 0, 1 * ret) * speed);
        this.transform.Translate(new Vector3(ret2, 0, ret) * speed * Time.deltaTime);

        // float elaped time, int count fps
        elapedtime += Time.deltaTime;
        count++;

        if (elapedtime >= 1.0f)
        {
            elapedtime = 0;
            fps = count;
            count = 0;
        }
        print(fps);
    }
}




//<vois Update> 메소드1
//this.transform.Translate(Vector3.forward * 0.02f);       //1초에 12번


//this.transform.position;    // 자료형
//this.transform.Translate(); // 이동 메서드
// 회전값과 회전방식은 차이가 있다.
//this.transform.rotation.x;      // 쿼터니온(언) , 사원수        값만 얻어올때
// 오일러 회전 -> 쿼터니온으로
// 쿼터니온 -> 오일러 회전으로 변환하는 메서드가 필요
// 복소수 기반의 좌표 계산 체계
//this.transform.Rotate();     // 오일러 회전. 0-360도          메서드로 쓸때
//this.transform.localScale;      // 확대, 축소





//<vois Update> 메소드2
/*
            if (Input.GetKeyDown(KeyCode.UpArrow) == true)                          // 리턴값 : bool형자료
            {
                ret = 1;
            }
            else
            {
                ret = 0;
            }
            */
