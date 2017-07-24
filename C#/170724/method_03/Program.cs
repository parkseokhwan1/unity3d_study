using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_03
{
    class Program
    {
        static int Fibnonacci(int n)
        {
            if (n < 2)
                return n;
            else
                return Fibnonacci(n - 1) + Fibnonacci(n - 2);
            // 10 :
            // 피보나치(9) + 피보나치(8)
            //              피보나치(7) + (6)
            //                            5   4
            //                              3   2
            //                                 1   0
        }

        static void PrintProfile(string name, string phone)
        {
            if (name == "")
            {
                Console.WriteLine("이름을 입력해주세요.");
                return;
            }

            Console.WriteLine("Name:{0}, Phone:{1}", name, phone);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("10번째 피보나치 수 : {0}", Fibnonacci(10));     // 피보나치 메서드 호출 - 피보나치 (10), 피보나치부터

            PrintProfile("", "123-4567");
            PrintProfile("박상현", "456-1230");
        }
    }

    /*
        // 재귀 메서드
        // 메서드 내에서 메서드를 호출 ( 자기 자신(현재 본인 메서드) 호출 )
        // => 끝이 있어야 한다, 없으면 무한루프
        // factorial => 5! ( 5*4*3*2*1 = ? )
        static uint factorial(uint number)
        {
            if (number <= 1)
                return 1;
            else
                return number * factorial(number - 1);
        }

        static void Main(string[] args)
        {
            uint result;
            result = factorial(5);
            Console.WriteLine("5! = 5*4*3*2*1 => " + result);
        }
        */

}
