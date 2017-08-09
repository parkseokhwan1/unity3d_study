using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class char_control : MonoBehaviour {
    public float mov_val;
    float dir_x;
    float dir_z;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        this.transform.Translate(new Vector3(1,0,0) * dir_x * Time.deltaTime * mov_val);
        this.transform.Translate(new Vector3(0,0,1) * dir_z * Time.deltaTime * mov_val);
    }

    public void click_up()     { dir_z =  1; }
    public void click_down()   { dir_z = -1; }
    public void click_left()   { dir_x = -1; }
    public void click_right()  { dir_x =  1; }

    public void click_up_x()   { dir_x =  0; }
    public void click_up_z()   { dir_z =  0; }

    public void click_fire()   { print("파이어"); }
    public void click_bomb()   { print("폭탄");   }
}
