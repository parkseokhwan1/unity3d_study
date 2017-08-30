using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_logic : MonoBehaviour {
    public int life = 10;
    public float mov_rate = 3f;
    bool drain_ok = true;
    bool is_Move = true;

	void Start () {
        life += GameData.m_Stage;
        is_Move = true;
	}

	void movement()
    {
        if (is_Move == true)
            this.transform.Translate(Vector3.forward * Time.deltaTime * mov_rate);
    }

    void life_drain()
    {
        life -= GameData.m_Power;
    }

    void enemy_state()
    {
        if(life <= 0)
        {
            GameData.m_Gold += 500 + 500 * GameData.m_Stage;
            GameData.enemy_count--;
            Destroy(this.gameObject);
        }
    }

    void Update()
    {
        if(GameData.isPause_state == false)
        {
            movement();
            enemy_state();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "base")
        {
            is_Move = false;
            if (drain_ok == true)
                StartCoroutine("drain_me");
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "base")
        {
            if (drain_ok == true)
                StartCoroutine("drain_me");
        }
    }

    IEnumerator drain_me()
    {
        drain_ok = false;
        yield return new WaitForSeconds(0.5f);
        GameData.m_myHp -= 0.5f;
        drain_ok = true;
    }
}
