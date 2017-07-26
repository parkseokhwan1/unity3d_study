using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MyClass
{
    int m_a;    // 아무것도 안쓰면 private 속성
    private int m_b;
    public int m_c;
    public int m_d;
    // C# 객체의 접근권한의 설정은 해당 멤버에만 적용
    // C# 외에는 해당 접근권한 셋팅, 셋팅이후의 모든 객체는 세팅된 권한을 따른다
    void init()
    {
        m_d = 3;
        m_b = 8;
    }
}

//class Program
//{
//    static void Main(string[] args)
//    {
//        MyClass aa = new MyClass();
//        aa.m_c = 33;
//        aa.m_d = 66;
//    }
//}


class Program
{
    static void Main()
    {
        Object a = 3.14f;
        int b = 123;

        int c = b;  // 데이터와 더불어 형태가 정해진 자료형 그냥 할당이 가능
        float d = (float) a;    // a 변수는 값만 들어가 있음 => 자료형의 종류는 셋팅이 안되어 있음
                                // 변수의 값을 넣는다 (박싱,          언박싱)
                                //                   데이터셋팅      자료형타입알려줌
        Console.Write("값은 {0}   {1}", c, d);
    }
}

