using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clear_logic : MonoBehaviour {
    public GameObject UI1, UI2;

    private void Awake()
    {
        UI_change(UI1, UI2);
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
