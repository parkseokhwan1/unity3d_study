using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class title_logic : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
    public void ExitProgram()
    {
        Application.Quit();
    }

    public void PlayScene_Load()
    {
        SceneManager.LoadScene("GameScene");    
    }
    // 유니티엔진에서 접근은 메서드나 자료형 둘다 가능하지만
    // 객체 내에서는 자료형 위주로 보인다.
    // 기능을 접근할 경우는 메서드가 보일 수 있다.
}
