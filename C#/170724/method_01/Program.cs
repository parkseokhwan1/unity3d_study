using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_01
{
    // 메서드 : 프로그램의 결과를 도출하는 로직을
    //         특정한 이름으로 정의한 것
    // 형식
    // C  :  returntype 메서드명 (파라미터)
    // C# :  접근권한 변수타입 returntype 메서드명 (파라미터)
    //       public    static     int      add    (int x, int y)
    // C# 언어의 메서드는 class 내에서 사용
    class Program
    {
        int numdata(int a)
        {
            int ret = 3;
            return ret;
        }
        void main2()
        {
            numdata(3);
        }

        // public, protected, private
        static int add_data(int a, int b)   // 넘겨지는 자료형이 어디에서 쓰이는가?
        {
            int ret = 0;
            ret = a + b;
            return ret;
        }
        // 실수, 문자

        static float add_data(float a, float b)
        {
            float ret = 0.0f;
            ret = a + b;
            return ret;
        }

        static string add_data(string a, string b)
        {
            string ret = "";
            ret = a + b;
            return ret;
        }
        // 함수의 중복정의 (Overload)
        // 컴파일러가 메서드를 인식할 때
        // 이름으로 인식? 또는 파라미터로 인식?
        // C 언어는 이름으로 인식, 메서드 이름은 중복 X -> unique
        // C# 언어는 파라미터 타입을 가지고 인식
        // 파라미터가 다르다면 같은 이름의 메서드를 사용해도 무방
        // 같은 이름의 같은 파라미터의 메서드 -> X
        // static int add_data(int x, int y)   
        // {
        //     int ret = 0;
        //     ret = x + y;
        //     return ret;
        // }
        static void aaa()
        {

        }
        static void Main(string[] args)     // static : 자료타입이 정적
                                            // 종료가 되기전 메모리상에 계속 존재하는 타입
                                            // 호출하는 메서드는 해당영역의 자료타입에 맞춰야 함
        {
            int num1, num2, num3;
            num1 = 123; num2 = 456; num3 = 0;
            // 두 수를 더하는 기능을 새로 정의
            num3 = add_data(num1, num2);    // 함수의 호출 (C, C# 동일)

            string str = add_data("abc", "123");
            Console.WriteLine(str);
            float fnum = add_data(3.0f, 0.14f);
            Console.WriteLine(fnum);
        }
    }
}
