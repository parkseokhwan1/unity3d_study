using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_ex05  
{
    class AAA
    {
          
        int m_a, m_b;
        // this.m_a; , 연산자, 클래스의 내부데이터
        // 클래스내의 : 연산자 영역지정 연산자
        // 생성자 : 리턴타입이 없는 클래스 이름을 가진 메서드
        public AAA() : this(0, 0) // AAA(0,0); => 클래스가 생성되고 생성자를 호출할때는 쓸 수 있지만
                        // 정의    -> 내부에 있는 생성자 메서드를 호출할 수는 없다
        {
        }
        // : 내 영역에 있는
        // : this() => this 생성자
        // => 현재 내 클래스에 작성된 다른 생성자를 호출할때
        // this 생성자는 현재 내가 작성중인 생성자를 호출할 수 없다
        // 이미 정의가 완료된 생성자만 호출이 가능하다
        public AAA(int a, int b)
        {
            m_a = a;
            m_b = b;
        }
    }

    class Program
    {
        static void Main()
        {
            AAA aa = new AAA(2, 3);
        }
    }
}
