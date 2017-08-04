using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleLogic : MonoBehaviour {
    float elapsedtime;
	// Use this for initialization
	void Start () {
        elapsedtime = 0;
	}
	
	// Update is called once per frame
	void Update () {
        // 5초뒤에 씬이동
        elapsedtime += Time.deltaTime;
        if (elapsedtime >= 5.0f)
        {
            elapsedtime = 0;
            SceneManager.LoadScene("GameScene");
        }
	}
}
