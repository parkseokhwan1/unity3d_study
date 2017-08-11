using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class title_logic : MonoBehaviour {

	public void GamePlay()
    {
        SceneManager.LoadScene("Game_scene");
    }

    public void Exit_Program()
    {
        Application.Quit();
    }

}
