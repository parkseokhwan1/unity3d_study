using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System;

[Serializable]
public class Game {
    public float music_vol1;
    public float music_vol2;
    public Game()
    {
        music_vol1 = 0;
        music_vol2 = 0;
    }
}

public class SoundVolume : MonoBehaviour {
    AudioSource audio1;
    public Slider sl;

    Game save_data = new Game();
    Game load_data = new Game();
    bool isLoad_data = false;

    void Start()
    {
        audio1 = this.GetComponent<AudioSource>();
        Load_Set();
        if(isLoad_data == false)
        {
            save_data.music_vol1 = audio1.volume = sl.value = 1.0f;
            save_data.music_vol2 = 0.5f;
        }
        audio1.Play();
    }

    public void SetVolumeData()
    {
        save_data.music_vol1 = sl.value;
        if (audio1 != null)
             audio1.volume = save_data.music_vol1;
    }

    void Update()
    {
        
    }

    void Save()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/save_sound.sv");
        bf.Serialize(file, save_data);
        file.Close();
    }

    void Load()
    {
        if (File.Exists(Application.persistentDataPath + "/save_sound.sv"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/save_sound.sv", FileMode.Open);
            load_data = (Game)bf.Deserialize(file);
            file.Close();
            isLoad_data = true;
        }
    }

    public void Save_Val()
    {
        Save();
    }

    public void Load_Set()
    {
        Load();
        audio1.volume = sl.value = load_data.music_vol1;
    }
}
