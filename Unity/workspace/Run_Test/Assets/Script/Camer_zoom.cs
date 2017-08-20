using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camer_zoom : MonoBehaviour {
    public GameObject player;
    public Camera cam;
    float camera_size = 8f;
    public float speed = 0.5f;
    public float maxsize = 15f;
    public float minsize = -3f;

    void Start () {
		
	}
	
	void Update () {
        //cam.orthographicSize;       // 평형투형에서 카메라범위(크기)를 얻어옴.
        camera_size = 11f + player.transform.position.y;
        if (camera_size >= maxsize)
            camera_size = maxsize;
        if (camera_size <= minsize)
            camera_size = minsize;
        cam.orthographicSize = Mathf.Lerp(cam.orthographicSize, camera_size, Time.deltaTime / speed);
	}
}
