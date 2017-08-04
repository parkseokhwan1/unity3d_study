using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageControl : MonoBehaviour {
    public float Rotate_rat;
    float xdir;
    float zdir;

    float playtime;     // 게임 진행시간
    bool ballstate;     // 상태
    // 3D 객체 자료형
    public GameObject ball;



    // Use this for initialization
    void Start () {
        xdir = zdir = 0;
        playtime = 0;
        ballstate = true;
	}
	
	// Update is called once per frame
	void Update () {
        Stage_rotate();

        playtime += Time.deltaTime;

        if (playtime >= 7.0f && ballstate == true)
            print("Clear");
            // 판    => 볼의 정보   
        
        if (ball.transform.position.y <= -10f)
            ballstate = false;
        

    }

    void Stage_rotate()
    {
        zdir = Input.GetAxis("Horizontal");
        xdir = Input.GetAxis("Vertical");

        this.transform.Rotate(new Vector3(1, 0, 0) * Rotate_rat * Time.deltaTime * xdir);     // X - rot
        this.transform.Rotate(new Vector3(0, 0, 1) * Rotate_rat * Time.deltaTime * zdir);     // Z - rot
    }
}
