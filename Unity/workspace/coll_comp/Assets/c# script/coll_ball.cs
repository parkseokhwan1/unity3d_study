using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coll_ball : MonoBehaviour {

    // Use this for initialization

    public float Rotate;
    private float roty_dir;

	void Start () {
        roty_dir = 0;

    }

    // Update is called once per frame
    void Update () {
        roty_dir = Input.GetAxis("Horizontal");

        this.transform.Rotate(new Vector3(0, Rotate, 0) * Time.deltaTime * roty_dir);
    }

    //Collider : 충돌을 검출하고 물리력인 충돌처리를 수행하는 객체
    //Triggr : 충돌을 검출하나 물리적인 충돌처리는 무시하는 객체

    private void OnCollisionEnter(Collision collision)      // 콜라이더 끼리 충돌되었는가?
    {
        // Collision collision 상대방
        print("충돌했음" + collision.gameObject.name);

    }
}
