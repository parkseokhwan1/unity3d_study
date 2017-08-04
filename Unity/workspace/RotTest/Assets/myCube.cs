using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myCube : MonoBehaviour {
    // 자료형의 선언
    // Use this for initialization
    public float Rotate;
    private float roty_dir;
    //private float rotx_dir;
    private float dir_fb;

    public float speed;

    private void Awake()
    {
        speed = 0.05f;
    }

    void Start () {
        // 초기화
        roty_dir = 0; //rotx_dir = 0;
        dir_fb = 0;
	}
	
	// Update is called once per frame
	void Update () {
        // 매 프레임마다 입력값을 체크
        roty_dir = Input.GetAxis("Horizontal"); // 1 , 0 , -1
        //rotx_dir = Input.GetAxis("Vertical");
        dir_fb = Input.GetAxis("Vertical");

        this.transform.Translate(new Vector3(0,0,1) * dir_fb * Time.deltaTime * 5);


        //로직의 제작
        //this.transform.Rotate(new Vector3(0,1,0) * Rotate * Time.deltaTime * roty_dir);       //반대방향 -1, vertical 옵션 invert 체크
        this.transform.Rotate(new Vector3(0,Rotate,0) * Time.deltaTime * roty_dir);
        //this.transform.Rotate(Vector3.up * Rotate * Time.deltaTime * roty_dir);
        //this.transform.Rotate(Vector3.right * Rotate * Time.deltaTime * rotx_dir);

        
    }
}
