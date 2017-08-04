using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plane_move : MonoBehaviour {
    public float Rotate_rat;
    float xdir;
    float zdir;

    // Use this for initialization
    void Start () {
        xdir = zdir = 0;
    }
	
	// Update is called once per frame
	void Update () {
        Plane_rotate();
    }

    void Plane_rotate()
    {
        zdir = Input.GetAxis("Horizontal");
        xdir = Input.GetAxis("Vertical");

        this.transform.Rotate(new Vector3(1, 0, 0) * Rotate_rat * Time.deltaTime * xdir);     // X - rot
        this.transform.Rotate(new Vector3(0, 0, 1) * Rotate_rat * Time.deltaTime * zdir);     // Z - rot
    }
}
