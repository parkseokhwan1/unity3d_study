using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// UGUI => UI 영역에 위치

using UnityEngine.UI;


public class char_control : MonoBehaviour {
    public float down_value, up_value;
    // Use this for initialization
    Vector3 down_force, up_force;

    public Transform fire_point;
    // public Text time_data;
    public GameObject bullet;   // 임시객체를 연결하기 위해서
    BoxCollider mycollider;     // 내 충돌체 정보를 받을 데이터 변수
    public float godtime;       // 무적일때 시간값을 받음

    void Start () {
        // down_value = 1f;
        mycollider = this.gameObject.GetComponent<BoxCollider>();
        godtime = 0;
    }
	
	// Update is called once per frame
	void Update () {
        down_force = Vector3.down * Time.deltaTime * down_value;
        this.transform.Translate(down_force + up_force);
        // 내 충돌체 속성 변경 - 무적일때(trigger - 3초후 - collider)
        if(mycollider.isTrigger == true)
        {
            godtime += Time.deltaTime;
            if(godtime >= 3.0f)     // 3초후에는 일반으로
            {
                mycollider.isTrigger = false;
                godtime = 0;
            }
        }
	}

    public void AllButtonDown()
    {
        // down_value = -2f;
        up_force = Vector3.up * Time.deltaTime * up_value;
        // project prefeb 객체를 생성한다.
        // => 다수의 객체를 만들기 때문에(생성하는 클래스에서 제어하는것이 아닌)
        // 프리펩에서 직접 제어한다
        // => 임시객체 (필요할때 잠깐 만들고 필요없으면 사라지게 만듬)
        // 1) file(project)에 있는 객체를 받는다 (파일과 유니티엔진 연결)

        // 객체를 만드는 메서드 instantiate()
        // 객체의 정보, 위치, 방향   (구형 4,5 버전 초기as 형변환 => 현재는 안씀)
        // 어느위치에 어느방향을 기준으로 생성할 것인가

        // 정보가 없기때문에 추가 셋팅이 불가 => 임시적으로 받을 변수가 필요
        // => 지역변수로 선언

        GameObject temp = Instantiate(bullet, fire_point.position, fire_point.rotation);
        Rigidbody temp2 = temp.GetComponent<Rigidbody>();
        temp2.AddForce(fire_point.forward * 1000f);

        AudioSource temp3 = this.gameObject.GetComponent<AudioSource>();
        if (temp3.isPlaying == false)
        {
            temp3.Play();
        }
    }

    public void AllButtonUp()
    {
        // down_value = -1f;
        up_force = Vector3.zero;
    }

    private void OnTriggerEnter(Collider other)
    {
        print(other.tag);
        if (other.tag == "bullet")
        {
            GameData.m_player_life -= 10;
            Destroy(other.gameObject);
        }
    }
}
