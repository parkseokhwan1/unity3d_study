using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public enum PlayerState { Run, Jump, D_Jump, Death}

public class Player_control : MonoBehaviour {
    public PlayerState Ps;
    public float Jump_power = 600f;
    public AudioClip[] sound;                   //효과음
    public Animator animator;                   //내부의 애니메이션 상태를 받고 변경하기 위한 변수

    AudioSource audio;
    public Game_manager GM;
	void Start () {
        audio = this.GetComponent<AudioSource>();
	}
	
	void Update () {
        this.GetComponent<Rigidbody>().WakeUp();    // 물리성질 한번 충돌체크한 후에
        // 자동적으로 슬립형태로 빠진다( 충돌처리횟수를 자동으로 최적화)
        // 강제로 슬립형태를 깨우는 방식으로 물리 처리 => 누락되는 충돌체크가 사라짐.
        if (Input.GetKeyDown(KeyCode.Space) == true && this.Ps != PlayerState.Death)
        {
            if (this.Ps == PlayerState.Jump) { D_Jump(); }
            if (this.Ps == PlayerState.Run ) { Jump();   }
        }

        if (Input.touchCount > 0)    // 화면에 어떠한 터치가 발생한 경우
        {
            // 화면의 터치는 마우스 좌클릭과 우클릭이랑 비슷한 느낌
            // 일반적인 터치는 마우스 왼쪽 클릭 (0: 왼쪽 클릭, 1: 오른쪽 클릭)
            // Touch.Began | move | exit
            if (EventSystem.current.IsPointerOverGameObject(0) == false)
            {
                if (Input.GetTouch(0).phase == TouchPhase.Began)
                {
                    if (this.Ps != PlayerState.Death)
                    {
                        if (this.Ps == PlayerState.Jump) { D_Jump(); }
                        if (this.Ps == PlayerState.Run) { Jump(); }
                    }
                }
            }
        }
	}

    void Jump()
    {
        Ps = PlayerState.Jump;
        animator.SetTrigger("Jump");
        animator.SetBool("Ground", false);

        this.GetComponent<Rigidbody>().AddForce(Vector3.up * Jump_power);
        SoundPlay(2);
    }

    void D_Jump()
    {
        Ps = PlayerState.D_Jump;
        animator.SetTrigger("D_Jump");
        animator.SetBool("Ground", false);

        this.GetComponent<Rigidbody>().AddForce(Vector3.up * Jump_power);
        SoundPlay(2);
    }

    //void Death()
    //{
    //    Ps = PlayerState.Death;
    //    SoundPlay(1);
    //}

    void Run()
    {
        Ps = PlayerState.Run;
        animator.SetBool("Ground", true);
    }

    void CoinGet()
    {
        SoundPlay(0);
        GM.CoinGet();
    }

    void GameOver()
    {
        this.Ps = PlayerState.Death;
        GM.GameOver();
        print("ps => " + this.Ps);
        SoundPlay(1);
    }

    void SoundPlay(int Num)
    {
        audio.clip = sound[Num];
        audio.Play();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (this.Ps != PlayerState.Run && this.Ps != PlayerState.Death) { Run(); }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Coin")
        {
            Destroy(other.gameObject);
            CoinGet();
        }
        if(other.gameObject.name == "DeathZone")
        {
            GameOver();
        }
    }
}
