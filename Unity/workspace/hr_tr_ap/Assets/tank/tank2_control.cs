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

public class tank2_control : MonoBehaviour {
    int mov_speed2 = 10;
    int rot_speed2 = 120;
    public GameObject Turret2;   // 포탑
    public GameObject Cannon2;   // 총구

    public GameObject bullet2;
    public Transform firepoint2;   // 좌표, 회전, 확대값을 얻는 객체

    // Update is called once per frame
    void Update() {
        CharMove2();
        TurretRot2();
        CannonRot2();

        if (Input.GetButtonDown("Fire02"))
            fireBullet2();
    }

    void fireBullet2()
    {
        GameObject bul = Instantiate(bullet2, firepoint2.position, firepoint2.rotation);
        //Rigidbody temp = bul.GetComponent<Rigidbody>();
        //temp.AddForce(firepoint.forward * 1000f);
        bul.GetComponent<Rigidbody>().AddForce(firepoint2.forward * 1000f);
        
    }

    void CannonRot2()
    {
        float dir_cannon_rot = Input.GetAxis("Mouse ScrollWheel");
        Cannon2.transform.Rotate(Vector3.left * dir_cannon_rot * Time.deltaTime * 160f);
        Vector3 ang = Cannon2.transform.eulerAngles;
        print("x:" + ang.x + "  y : " + ang.y + "   z : " + ang.z);
        if (ang.x > 270) ang.x -= 360; // 30
        ang.x = Mathf.Clamp(ang.x, -20f, 20f);
        //Vector3 kakdo = new Vector3(-330, 0, 0);
        Cannon2.transform.eulerAngles = ang;
    }

    void TurretRot2()
    {
        // q , e 포탑 회전
        // 포탑의 정보를 알아야 => 객체를 받아야 함
        // GameObject
        // 객체의 이동 혹은 회전

        float dir_turret_rot = Input.GetAxis("Turret");
        Turret2.transform.Rotate(Vector3.up * rot_speed2 * Time.deltaTime * dir_turret_rot);
    }

    void CharMove2()
    {
        float mov_rate2 = mov_speed2 * Time.smoothDeltaTime;
        float rot_rate2 = rot_speed2 * Time.smoothDeltaTime;

        float mov_dir2 = Input.GetAxis("Vertical2");
        float rot_dir2 = Input.GetAxis("Horizontal2");

        this.transform.Translate(new Vector3(0, 0, 1) * mov_rate2 * mov_dir2);
        //this.transform.Rotate(new Vector3(0, rot_dir, 0) * rot_rate);
        this.transform.Rotate(Vector3.up * rot_dir2 * rot_rate2);
    }

}
