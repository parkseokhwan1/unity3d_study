using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aa : MonoBehaviour {
    bool isdown;
    Vector3 temp;
    // Use this for initialization
    void Start () {
        // 객체생성후 렌더링 전에 한번 호출되는부분
        // 1번만 호출
        // => 초기화 루틴을 주로 장착
        isdown = false;
	}

    // Update is called once per frame
    void Update()
    {
        // 매 프레임별 렌더링 처리시 사용
        // 위치를 출력할것임 , y값 : 높이
        print(this.transform.position.y);


        //    this.transform.position.y = -5.0f;
        // 3D 객체에서 좌표 데이터는 말단을 셋팅할 수 없다.
        // vector = new Vector();   O
        // position.y = -5.0f;   X
        // unity엔진에서 C# 스크립트를 썼을때만
        // cf) javascript 는 최종말단 데이터도 직접셋팅이 가능하다
        // position.y = -5.0f   O

        // 1) unity에 제공되는 방향, 값 셋팅  cf) vector3.forward;
        // 2) vector3 자료형을 만들고, 셋팅

        if (this.transform.position.y <= -5.0f)        // 좌표, 말단데이터는 얻을수 있지만,
                                                       // 셋팅이 안됨
        {
            
            // 1) 직접 데이터형을 셋팅하고 만든다.
            if(this.isdown == false)        // 1번만
            {
                this.isdown = true;
                temp.x = transform.position.x;
                temp.y = -5.0f;
                temp.z = transform.position.z;
                
            }
            // temp.x = 0; temp.y = -5; temp.z = 0;
            // 2) Vector3 temp = new Vector3(0, -5, 0);
            // 3) this.transform.position = new Vector3(transform.position.x, -5, transform.position.z);
            this.transform.position = temp;
        }
    }
}
