using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public enum GameState {
    Play,
    Pause,
    End
}

public class Game_manager : MonoBehaviour {
    public GameState Gs;        // 현재 UI 상태
    public Text Text_Meter;
    public Text Text_Gold;

    public GameObject Result_UI;
    public Text Final_Meter;
    public Text Final_Gold;

    public GameObject Pause_UI;

    public float Speed;
    public float Meter;
    public int Gold;

    void Update()
    {
        if(Gs == GameState.Play)
        {
            Meter += Time.deltaTime * Speed;
            Text_Meter.text = string.Format("{0:N1} m", Meter);     // 소수점 자리 1으로
        }
    }

    public void CoinGet()
    {
        Gold += 1;
        Text_Gold.text = string.Format("{0}", Gold);
    }
    
    public void GameOver()
    {
        Result_UI.SetActive(true);
        Final_Meter.text = string.Format("{0:N1} ", Meter);
        Final_Gold.text = string.Format("{0}", Gold);
        Gs = GameState.End;
        // 평소에 숨겨온 GUI. active 시킴. 
    }

    public void Retry()
    {
        SceneManager.LoadScene("GameScene");
        Time.timeScale = 1f;
    }

    public void GoMain()
    {
        SceneManager.LoadScene("TitleScene");
        Time.timeScale = 1f;
    }

    public void Paused()
    {
        // Time.timeScale;  // 값의 변화에 따라서 프레임을 변화 시킬수 있다.
        Time.timeScale = 0f;
        Gs = GameState.Pause;
        Pause_UI.SetActive(true);
    }

    public void UnPaused()
    {
        Time.timeScale = 1f;
        Gs = GameState.Play;
        Pause_UI.SetActive(false);
    }
}

