using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
    Get Axis 의 설정
    name : 입력데이터의 이름(소스코드에서 확인할 수 있음)
    negative button : 음의방향 버튼
    positive button : 양의방향 버튼
    gravity : 키 버튼을 누르지 않을때 중립값이 되는 시간 ( 0 ),
    값이 0으로 도달되는 시간 => 값이 크면 빨리 멈추게 된다.
    dead = 0 입력을 멈추었을때 값이 되는 크기 (조이스틱이나 게임패드장비)
    sensitivity : 키나 조이스틱의 반응속도
    snap : 방향버튼을 누르다가 반대 버튼을 눌렀을때 바로 반응 되는 속성
    invert : 방향을 반대로
 */

public class tank1_control : MonoBehaviour {
    int mov_speed = 10;
    int rot_speed = 120;
    public GameObject Turret;   // 포탑
    public GameObject Cannon;   // 총구

    public GameObject bullet;
    public Transform firepoint;   // 좌표, 회전, 확대값을 얻는 객체

    // Update is called once per frame
    void Update() {
        CharMove();
        TurretRot();
        CannonRot();

        if (Input.GetButtonDown("Fire1"))
            fireBullet();
    }

    void fireBullet()
    {
        GameObject bul = Instantiate(bullet, firepoint.position, firepoint.rotation);
        //Rigidbody temp = bul.GetComponent<Rigidbody>();
        //temp.AddForce(firepoint.forward * 1000f);
        bul.GetComponent<Rigidbody>().AddForce(firepoint.forward * 1000f);
        
    }

    void CannonRot()
    {
        float dir_cannon_rot = Input.GetAxis("Mouse ScrollWheel");
        Cannon.transform.Rotate(Vector3.left * dir_cannon_rot * Time.deltaTime * 160f);
        Vector3 ang = Cannon.transform.eulerAngles;
        print("x:" + ang.x + "  y : " + ang.y + "   z : " + ang.z);
        if (ang.x > 270) ang.x -= 360; // 30
        ang.x = Mathf.Clamp(ang.x, -20f, 20f);
        //Vector3 kakdo = new Vector3(-330, 0, 0);
        Cannon.transform.eulerAngles = ang;
    }

    void TurretRot()
    {
        // q , e 포탑 회전
        // 포탑의 정보를 알아야 => 객체를 받아야 함
        // GameObject
        // 객체의 이동 혹은 회전

        float dir_turret_rot = Input.GetAxis("Turret");
        Turret.transform.Rotate(Vector3.up * rot_speed * Time.deltaTime * dir_turret_rot);
    }

    void CharMove()
    {
        float mov_rate = mov_speed * Time.smoothDeltaTime;
        float rot_rate = rot_speed * Time.smoothDeltaTime;

        float mov_dir = Input.GetAxis("Vertical");
        float rot_dir = Input.GetAxis("Horizontal");

        this.transform.Translate(new Vector3(0, 0, 1) * mov_rate * mov_dir);
        //this.transform.Rotate(new Vector3(0, rot_dir, 0) * rot_rate);
        this.transform.Rotate(Vector3.up * rot_dir * rot_rate);
    }

}
