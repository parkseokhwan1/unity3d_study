using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cam_control : MonoBehaviour {
    float keyproc = 0;
    public float mov_rate = 14f;
    public Text Normal_txt;    //stage
    public Text Normal_txt1;   //gold
    public Text Normal_txt2;   //hp

    public Text VR_Ltxt;    
    public Text VR_Ltxt1;   
    public Text VR_Ltxt2;   

    public Text VR_Rtxt;    
    public Text VR_Rtxt1;   
    public Text VR_Rtxt2;   

    public GameObject castle;
    
    public GameObject Normal_Cam;
    public GameObject VR_Cam;

    public GameObject Normal_UI;
    public GameObject VR_UI_L;
    public GameObject VR_UI_R;

    public GameObject enemy1;       // 프리팹 객체
    public Transform enemy_regen;   // 적군이 나올 좌표
    bool regen_time = true;          // 적군이 나오는 시간을 체크
    public int regen_count;

    float scene_movetime = 0;
    public int isWin = 0;           // -1 : lose, 0 : win
    public Camera mainCam;
    public Camera VrCamL;
    public Camera VrCamR;

    void Awake()
    {
        // 디버깅

        if(GameData.is_VrMode == false)
        {
            Normal_Cam.SetActive(true);
            VR_Cam.SetActive(false);

            Normal_UI.SetActive(true);
            VR_UI_L.SetActive(false);
            VR_UI_R.SetActive(false);
        }
        else
        {
            Normal_Cam.SetActive(false);
            VR_Cam.SetActive(true);

            Normal_UI.SetActive(false);
            VR_UI_L.SetActive(true);
            VR_UI_R.SetActive(true);
        }
        print("VR_Mode -> " + GameData.is_VrMode);
    }

    public void let_pause()
    {
        GameData.isPause_state = true;
    }

    public void let_resume()
    {
        GameData.isPause_state = false;
    }

    void Start()
    {
        GameData.enemy_count = GameData.enemy_num;
        regen_count = GameData.enemy_num;

        print(GameData.m_Stage);
        Showinfo();
        
        scene_movetime = 0;
        GameData.m_myHp = 100f;
    }

    void Showinfo()
    {
        Normal_txt.text = "Stage : " + GameData.m_Stage;
        Normal_txt1.text = "Gold : " + GameData.m_Gold;
        Normal_txt2.text = "HP : " + GameData.m_myHp;

        VR_Ltxt.text = "Stage : " + GameData.m_Stage;
        VR_Ltxt1.text = "Gold : " + GameData.m_Gold;
        VR_Ltxt2.text = "HP : " + GameData.m_myHp;

        VR_Rtxt.text = "Stage : " + GameData.m_Stage;
        VR_Rtxt1.text = "Gold : " + GameData.m_Gold;
        VR_Rtxt2.text = "HP : " + GameData.m_myHp;
    }

    void Update()
    //print("isPause_state = " + GameData.isPause_state);
    {
        Showinfo();
        if (GameData.isPause_state == false)
        {
            camera_control();  // 화면 움직임
            Enemy_logic();  // 적군 움직임
            if (Input.GetMouseButtonDown(0))
            {
                char_recog();
            }
            Game_rule();
        }
        print("VR_Mode -> " + GameData.is_VrMode);
    }

    void camera_control()
    {
        Vector3 dir = Vector3.zero;
        dir.x = Input.acceleration.x;
        this.transform.Translate(Vector3.right * Time.deltaTime * keyproc * mov_rate);  // pc
        this.transform.Translate(Vector3.right * Time.deltaTime * mov_rate * dir.x);    // mobile
        if (transform.position.x <= -38) transform.position = new Vector3(-38f, 2.5f, -12f);
        if (transform.position.x >= 38)  transform.position = new Vector3( 38f, 2.5f, -12f);
    }

    public void move_end()
    {
        keyproc = 0;
    }

    public void move_left()
    {
        keyproc = -1;
    }

    public void move_right()
    {
        keyproc = 1;
    }

    void Enemy_logic()
    {
        if (regen_count > 0 && regen_time == true)
            StartCoroutine("CreateEnemy");
    }

    IEnumerator CreateEnemy()
    {
        Vector3 temp_pos = enemy_regen.transform.position;
        Vector3 pos = new Vector3(temp_pos.x, temp_pos.y, Random.Range(-5f, 5f));

        regen_time = false;
        Instantiate(enemy1, pos, enemy_regen.transform.rotation);

        yield return new WaitForSeconds(0.5f);
        regen_time = true;
        regen_count--;
    }

    void Game_rule()
    {
        if(GameData.m_myHp <= 0)
        {
            Destroy(castle);
            isWin = -1;
        }

        if(isWin == -1)
        {
            scene_movetime += Time.deltaTime;
            if (scene_movetime >= 2f)
            {
                scene_movetime = 0;
                SceneManager.LoadScene("Title_menu");       // 게임오버
            }
        }

        if(GameData.enemy_count <= 0)
        {
            print("-------------");
            isWin = 1;
            scene_movetime += Time.deltaTime;
            if(scene_movetime >= 2f)
            {
                scene_movetime = 0;
                SceneManager.LoadScene("Title_menu");       // 게임클리어
            }
        }
    }

    void char_recog()
    {
        RaycastHit hit;
        Ray ray; // = new Ray();

        print(Input.mousePosition);
        print(Screen.width);

        if (GameData.is_VrMode == false)
        {
            ray = mainCam.ScreenPointToRay(Input.mousePosition);

        }
        else
        {
            if(Input.mousePosition.x < (Screen.width / 2))
            {
                ray = VrCamL.ScreenPointToRay(Input.mousePosition);
            }
            else
            {
                ray = VrCamR.ScreenPointToRay(Input.mousePosition);
            }
        }

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform.gameObject.tag == "enemy")
            {
                hit.transform.SendMessage("life_drain", null,
                SendMessageOptions.DontRequireReceiver);
            }
        }
    }
}
