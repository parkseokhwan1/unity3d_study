using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class title_logic : MonoBehaviour {
    public GameObject UI_phone;
    public GameObject UI_watch;

    private void Awake()
    {
        Phone_detect();
        UI_change(UI_phone, UI_watch);
    }

    private void Start()
    {
        
    }

    public void GamePlay()
    {
        SceneManager.LoadScene("Game_scene");
    }

    public void Exit_Program()
    {
        Application.Quit();
    }

    void Phone_detect()
    {
        float width_, height_, res_val;
        width_ = (float)Screen.width;
        height_ = (float)Screen.height;
        res_val = width_ / height_;
        if (res_val > 1.35f)
            GameData.istarget_phone = true;
        else
            GameData.istarget_phone = false;
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
}
