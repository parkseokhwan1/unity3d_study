using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struct_ex01
{
    // 구조체, 사용자 정의 자료형
    // 형식
    /*
        struct 자료형이름
        {
            멤버 데이터
        }
     */
    // 사용
    // 자료형이름 변수
    // 변수.멤버

    struct Hero
    {
        // 내부를 접근할 때 보호 수준이 있다 (접근권한)
        // public, protected, private
        public int hp;
        public int mp;
        // C# 기능도 넣을 수 있다(메서드)
        public void init_data()
        {
            hp = 300;       // 저장공간 없음(선언만)
            mp = 300;
        }   // 선언부인 경우에는 저장공간 없음

        public void print()
        {
            Console.WriteLine("aaa{0}bbb{1}", hp, mp);
        }

    }   // 구조체 내부

    class Program
    {
        // 구조체 외부
        static void Main(string[] args)
        {
            // 직접접근 => 변수처럼 가져다 씀
            Hero ironman;   // => 자료형을 선언
            // 멤버를 직접 접근, 값 셋팅 => 일반변수처럼 사용이 됨
            ironman.hp = 100;
            ironman.mp = 100;
            Console.WriteLine("aaa{0}bbb{1}", ironman.hp, ironman.mp);

            // 구조체 내부에 있는 메서드 사용
            // 간접접근 (저장공간을 만들고 해당 주소를 받음)
            Hero spiderman = new Hero();
            // Hero *spiderman = Malloc(sizeof(Hero));
            spiderman.init_data();
            spiderman.print();

        }
    }
}
