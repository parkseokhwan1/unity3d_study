using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// namespace :
// 다중작업을 통해 프로젝트 구성시
// 클래스(메서드)의 중복이 생길수 있다
// 해당 클래스를 구분지을 수 있는 영역을 만들어 클래스를 제작하면
// 중복이나 모호성을 해소할 수 있다.  => namespace
// => 같은 이름의 클래스가 있어도 충돌 안나게
/*
 형식
 // 선언
 namespace 영역이름
 {
    클래스를 구현
 }

    사용
    영역이름.클래스명 변수 = new 영역이름.클래스명();
    // namespace 를 이용한 객체는 해당 namespace (영역이름)을 명시해야 한다
    => 네임스페이스내에 정의된 클래스를 참조할때  '.' 연산자를 사용한다

    */

// 서로 다른 namespace

namespace AA    // 
{
    class card_data
    {
        public int m_a;
    }
}

namespace BB
{
    class card_data
    {
        public int m_a;
    }
}

// namespace 내에 namespace 가 들어갈 수 있는가?
// 중첩해서 사용할 수 있다
// 사용은?

namespace CC
{
    class card_data
    {
        public int m_a;
    }
    namespace DD
    {
        // cc.dd
        class card_data
        {
            public int m_a;
        }
    }
}



class Program
{
    static void Main(string[] args)
    {
        // card_data a;    // error : 영역명시 안함
        AA.card_data a = new AA.card_data();
        BB.card_data b = new BB.card_data();

        // 사용은 기존과 동일
        Console.WriteLine("{0} , {1}", a.m_a, b.m_a);

        CC.card_data c = new CC.card_data();
        CC.DD.card_data d = new CC.DD.card_data();
        c.m_a = d.m_a;
    }
}


