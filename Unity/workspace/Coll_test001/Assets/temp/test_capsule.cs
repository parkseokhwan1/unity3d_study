using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*  1)
 
public class test_capsule : MonoBehaviour {
    public GameObject[] rockdata;
    private Rigidbody[] gv_r = new Rigidbody[5];

    // Use this for initialization
    void Start () {
        for (int i=0; i<rockdata.Length; i++)
        {
            gv_r[i] = rockdata[i].GetComponent<Rigidbody>();
        }
        //gv_r1 = rockdata2.GetComponent<Rigidbody>();
        //gv_r2 = rockdata3.GetComponent<Rigidbody>();
        //gv_r3 = rockdata4.GetComponent<Rigidbody>();
        //gv_r4 = rockdata5.GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        for (int i = 0; i < rockdata.Length; i++)
        {
            gv_r[i].useGravity = true;
        }
    }

   
}
*/



/*  2)
   
   
public class test_capsule : MonoBehaviour
{
    static public bool states = false;

    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        states = true;
    }
}
*/



public class test_capsule : MonoBehaviour
{
    public GameObject guard;
    //3 
    //BoxCollider gd;

    void Start()
    {
        // 공이 떨어질만한 속성을 셋팅
        // 충돌 속성 collider -> trigger
        // gd = guard.GetComponent<BoxCollider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        // gd.isTrigger = true;
        // 3.5
        // destroy 개념 => 객체는 필요에 따라 삭제가 가능
        DestroyObject(guard);
    }
}