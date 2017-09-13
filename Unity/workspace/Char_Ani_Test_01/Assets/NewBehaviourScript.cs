using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    float xRkey, ykey;
    public GameObject ch;

    Animator animator;
    void Start () {
        animator = ch.GetComponent<Animator>();
    }
	
	void Update () {
        xRkey = Input.GetAxis("Horizontal");
        ykey = Input.GetAxis("Vertical");
        print(ykey);

        animator.SetFloat("Speed", Mathf.Abs(ykey));        // ykey의 절대값
        this.transform.Translate(Vector3.forward * Time.deltaTime * ykey * 2.0f);
        this.transform.Rotate(Vector3.up * Time.deltaTime * xRkey * 120f);
    }
}
