using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
// 일반화(Generic) 클래스 - 템플릿(c++) 클래스
// java, c#
// 클래스 선언시 필요한 내부의 멤버 자료형이 
// 일반화 자료형으로 만들어진 클래스
// 자료형의 구체적인 형태는 객체 생성시에 지정함
// 형식
/*
선언
class 클래스명 <T>
{
    T 멤버    생성
}
*/

class A     //-> A()
{
    public int m_x;
    public int m_y;
    public float m_z;
    public float m_t;
}

// <단어>    // 무슨자료형이든 올 수 있다 <> 내부의 단어는 중요하지 않음
            // <    >  

class A<G,S>  // 일반화클래스 = 클래스 + 일반화자료형
              // 일반자료형은 1개 이상이 올 수 있다, 구분을 위해서 ','를 사용
              // A <G,S>();
{
    public G m_x;
    public G m_y;
    // public float m_z;   // 1) 보통 멤버변수가 올 수도 있다.
    public S m_z;
    public S m_t;
}

/*
<사용>
        // 자료형
클래스형<일반화키워드> 변수 = new 생성자<일반화키워드>();
*/

class connector<G>
{
    public string connect(G a, G b)
    {
        return a.ToString() + b.ToString();
    }
}

namespace Generic02
{
    class Program
    {
        static void Main(string[] args)
        {
            A<int, float> a = new A<int, float>();
            a.m_x = 1;
            a.m_t = 3.14f;

            connector<int> c = new connector<int>();
            Console.WriteLine(c.connect(123, 486));
        }
    }
}
