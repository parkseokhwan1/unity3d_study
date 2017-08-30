using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameData : MonoBehaviour {
    static public int m_Gold = 0;
    static public int m_Power = 1;
    static public int m_Stage = 1;
    static public float m_myHp = 100f;

    static public int enemy_num = 5;  // 적 개수
    static public int enemy_count = 5;   // 죽을때 사라지는 적 개수
    static public bool isPause_state = false;
    static public bool is_VrMode = false;

    public Toggle check_VR;
    public Text sec_text;
    public float WaitSecond = 10f;
    bool is_showSec = false;

    void Update()
    {
        if (is_showSec == true)
        {
            WaitSecond -= Time.deltaTime;
            if (WaitSecond < 0)
            {
                WaitSecond = 10;
                is_showSec = false;
                SceneManager.LoadScene("Game_scene");
            }
            sec_text.gameObject.SetActive(true);
            sec_text.text = ((int)WaitSecond).ToString();
        }
    }

    public void VrMode_check()
    {
        if (check_VR.isOn == true) is_VrMode = true;
        else is_VrMode = false;

        print("Vr_Mode => " + is_VrMode);
    }

    public void NormalMode()
    {

    }

    static public void initData()
    {
        isPause_state = false;

        m_Gold = 0;
        m_Power = 1;
        m_Stage = 1;
        m_myHp = 100 * m_Power;
    }

    public void NextScene()
    {
        is_showSec = true;
    }

    public void GoTitle()
    {
        SceneManager.LoadScene("Title_menu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
