using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_control : MonoBehaviour {
    public int Life = 2;
	void Start () {}
	void Update () {
        if (Life == 0)
            Destroy(this.gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        print(other.tag);
        if (other.tag == "bullet")
            Life -= 1;
        if (other.tag == "player")
        {
            GameData.m_player_life -= 10;
            Life = 0;
            Destroy(this.gameObject);
        }
    }
}
