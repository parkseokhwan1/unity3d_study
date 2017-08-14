using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameRule_logic : MonoBehaviour {
    
    // 좌표를 얻어옴
    public Transform[] enemypos = new Transform[2];
    public GameObject Enemy;
    public GameObject BossChar;
    float timesec;
    float elapsedtime;

    public Text sec_temp;       
    public Text playerlife_temp;
    public Text bosslife_temp;
    public GameObject UI1, UI2;

    private void Awake()
    {
        UI_change(UI1, UI2);
    }

    void UI_change(GameObject ui1, GameObject ui2)
    {
        if (GameData.istarget_phone == true)
        {
            ui1.SetActive(true);
            ui2.SetActive(false);
        }
        else
        {
            ui1.SetActive(false);
            ui2.SetActive(true);
        }
    }

    void Start () {
        timesec = 0;
        //print(Screen.width / Screen.height);
        //print(Screen.height);
        float width_ = (float)Screen.width;
        float height_ = (float)Screen.height;
        float resval = width_ / height_;
        print(resval);
    }

    void debug_ui()             
    {
        int temp_sec = (int)timesec;
        sec_temp.text = "Time : " + temp_sec.ToString();
        playerlife_temp.text = "Life : " + GameData.m_player_life.ToString();
        bosslife_temp.text = "Boss : " + GameData.m_boss_life.ToString();
    }
    
	// Update is called once per frame
	void Update () {
        // 5초부터
        timesec += Time.deltaTime;
        debug_ui();
        Enemy_Create();
        isGameOver();
        isClear();
	}

    void isGameOver()
    {
        if (GameData.m_player_life <= 0)
        {
            GameData.m_player_life = 0;
            SceneManager.LoadScene("Gameover_scene");
        }
    }

    void isClear()
    {
        if (GameData.m_boss_life <= 0)
        {
            GameData.m_boss_life = 0;
            SceneManager.LoadScene("ClearScene");       
        }
    }

    void Enemy_Create(){
        if (timesec >= 5.0f && timesec <= 40.0f){
            // 적을 발사 // instantiate => addforce;
            elapsedtime += Time.deltaTime;  // 내부 호출시간

            if (elapsedtime > 3.0f){
                elapsedtime = 0;
                for (int i = 0; i < enemypos.Length; i++){
                    GameObject temp = Instantiate(Enemy, enemypos[i].position, enemypos[i].rotation);
                    Rigidbody temp2 = temp.GetComponent<Rigidbody>();
                    temp2.AddForce(enemypos[i].forward * 100f);
                }
            }
        }

        if (timesec > 40.0f && GameData.isBossSee == false){
            GameData.isBossSee = true;
            GameObject temp = Instantiate(BossChar, enemypos[1].position, enemypos[1].rotation);
            Rigidbody temp2 = temp.GetComponent<Rigidbody>();
            temp2.AddForce(enemypos[1].forward * 5f);
        }

    }
}
