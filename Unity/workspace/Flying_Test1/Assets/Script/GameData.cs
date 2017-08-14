using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 데이터 용도로만 사용
public class GameData : MonoBehaviour {
    static public float m_player_life = 100f;
    static public float m_music_volume = 100f;
    static public float m_fx_volume = 100f;
    static public bool isBossSee = false;       // 출몰여부
    static public bool isBossInfinity = true;
    // 보스의 상태   1 : 무적  0 : 무적이 아님
    static public float m_boss_life = 100f;

    static public bool istarget_phone = true;
}
