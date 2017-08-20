using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title_control : MonoBehaviour {
    public void play_game()
    {
        SceneManager.LoadScene("GameScene");
    }
}
