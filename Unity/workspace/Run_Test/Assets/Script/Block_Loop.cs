using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block_Loop : MonoBehaviour {
    public float Block_Speed = 6;

    public GameObject[] Block;      // 프리팹받는 배열

    public GameObject A_Zone;
    public GameObject B_Zone;
    //public GameObject Block;    // 프리팹을 통해서 계속만들어지는 객체

	void Update () {
        move();
	}

    void move()
    {
        A_Zone.transform.Translate(Vector3.left * Block_Speed * Time.deltaTime);
        B_Zone.transform.Translate(Vector3.left * Block_Speed * Time.deltaTime);
        if(B_Zone.transform.position.x <= 0)
        {
            Destroy(A_Zone);
            A_Zone = B_Zone;
            MakeBlock();
        }
    }

    void MakeBlock()
    {
        int numdata = Random.Range(0, Block.Length);
        B_Zone = Instantiate(Block[numdata], new Vector3(30, -10, 0), this.transform.rotation);
    }
}
