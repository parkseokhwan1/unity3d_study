using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene_move : MonoBehaviour {

	void Start () {
		
	}
	
	void Update () {
		
	}

    public void nextScene()
    {
        SceneManager.LoadScene(1);
    }

    public void prevScene()
    {
        SceneManager.LoadScene(0);
    }
}
