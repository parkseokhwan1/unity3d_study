using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class aeroplane_control : MonoBehaviour {
    public float speed = 10f;
    float flightsize = (float)Screen.width * 0.1f;
    public GameObject model;
    public GameObject bullet;
    public Transform firepoint;

    public Image gauge;
    bool canfire = true;
    float firetime = 0;
    Vector2 imgsize;
    void Start () {
        imgsize = gauge.rectTransform.sizeDelta;    // 객체의 크기
        //gauge.rectTransform.sizeDelta = new Vector2(200, 22);
    }
	
	void Update () {
        AirplaneMove();
        if (Input.GetButton("Fire1"))
        {
            StartCoroutine("makemissile");
            //makemissile();
        }
    }
    // 메서드 호출하되 한번작동후 특정시간동안 보류시키는 메서드
    // 1) 원하는 메서드를 알아야
    // 2) 얼만큼 보류시킬지 셋팅
    /*
      1) StartCoroutine("함수명");
      => 해당기능에 작동하는 메서드의 형태
      void 메서드명(인자) => Ienumurator 메서드명(파라미터 없음)

      2) Ienumurator 메서드명(파라미터 없음)
      {
        처리할 로직          => 1번 작동후
                                return 에서 셋팅한 시간이 완료될때까지는 보류
        yield return 시간값 (보류타임)
        3) 보류타임 이후에 처리할 로직부
      }
    */

    IEnumerator makemissile()   // IEnumerator 형태로 선언된 메서드 => 코루틴
    {
        canfire = false;
        GameObject temp = Instantiate(bullet, firepoint.position, firepoint.rotation);
        // 힘을 준다 . 물리
        temp.GetComponent<Rigidbody>().AddForce(Vector3.forward * 200f);

        yield return new WaitForSeconds(0.2f);  // 보류시간
        canfire = true;     // 보류시간 이후에 처리
    }

    void AirplaneMove()
    {
        //print(flightsize);
        float mov_rate = speed * Time.deltaTime;
        float movx_key = Input.GetAxis("Horizontal");
        //float movy_key = Input.GetAxis("Y-Arrow");          // r , f
        //float movz_key = Input.GetAxis("Vertical");
        model.transform.eulerAngles = new Vector3(0, 0, -30f * movx_key);

        Vector3 conv2dpos = Camera.main.WorldToScreenPoint(this.transform.position);
        //print(Screen.width + " | " + conv2dpos.x);
        if ((movx_key < 0 && conv2dpos.x > (flightsize)) ||            // -
            movx_key > 0 && conv2dpos.x < (Screen.width - flightsize))      // +
        {     
            this.transform.Translate(Vector3.right * mov_rate * movx_key);
        }
        //this.transform.Translate(Vector3.forward * mov_rate * movy_key * -1);
        //this.transform.Translate(Vector3.up * mov_rate * movz_key * -1);

        if (Input.GetKeyDown(KeyCode.P))
        {
            game_data.Myhp += 10;
            if (game_data.Myhp >= 100) game_data.Myhp = 100;
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            game_data.Myhp -= 10;
            if (game_data.Myhp <= 0) game_data.Myhp = 0;
        }

        gauge.rectTransform.sizeDelta = new Vector2(imgsize.x * (float)game_data.Myhp * 0.01f, imgsize.y);
    }
}


/*
    void makemissile()
    {
        if( canfire == true )
        {
            GameObject temp = Instantiate(bullet, firepoint.position, firepoint.rotation);
            // 힘을 준다 . 물리
            temp.GetComponent<Rigidbody>().AddForce(Vector3.forward * 200f);
            canfire = false;
        }
        firetime += Time.deltaTime;
        if (firetime >= 0.2f)
        {
            firetime = 0;
            canfire = true;
        }
    }
    */
