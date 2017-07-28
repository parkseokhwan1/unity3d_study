using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 사용자 정의
using Tokyo;
using Tokyo.Tosima; // 각 영역별로 namespace 이름을 넣어준다
// namespace 를 축약 혹은 다른 이름으로 정의가능?

namespace Tokyo
{
    class Tokyotower
    {
        public void print()
        {
            Console.WriteLine("도쿄타워 입니다");
        }
    }
    namespace Tosima
    {
        class sunshine
        {
            public void print()
            {
                Console.WriteLine("선샤인60");
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // 생성이 너무 빡셈
        // 생성을 좀 쉽게 하고싶은데
        // namespace 를 미리 등록 => 사용할때 알아서 내부의 데이터(클래스) 접근할 수 있다
        // using -> 해당 namespace 영역에 있는 다양한 클래스나 메서드나 자료형을 쓰겠다.
        // 사용법
        // using namespace; // using 다음에는 namespace만 올 수 있다 (클래스 자리가 아님)
                            // 프로그램 시작전에 먼저 선언해 준다
                            // 내가 선언한 namespace 내의 영역 => 클래스나 메서드만
                            // 내부에 선언되어 있는 namespace 는 안보여줌
        Tokyo.Tokyotower tower = new Tokyo.Tokyotower();
        Tokyo.Tosima.sunshine sn = new Tokyo.Tosima.sunshine();

        Tokyotower tower2 = new Tokyotower();
        sunshine sn2 = new sunshine();

        tower.print();
        sn.print();

        System.Console.WriteLine("");
    }
}

