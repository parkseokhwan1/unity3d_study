using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_ani : MonoBehaviour {

	void Update () {
        this.transform.Rotate(Vector3.left * Time.deltaTime * 720f);
	}
}
