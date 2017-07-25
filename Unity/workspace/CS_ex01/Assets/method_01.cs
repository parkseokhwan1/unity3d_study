using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class method_01 : MonoBehaviour {
	// Use this for initialization
	void Start () 	//static void main() 과 기능적으로 비슷함
	{
		int a, b, ret;
		a = 5; b = 3; ret = 0; 

		ret = Add_data (a, b);
		// console.writeline		비슷한 메서드
		// Debug.Log(); print();
		print("값은" + ret);
	}

	int Add_data (int x, int y)
	{
		temp ();
		int ret;
		ret = x + y;
		return ret;
	}

	void temp()
	{
		print ("method working");
	}
}
	

