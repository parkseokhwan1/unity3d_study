using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable01
{
    // \n \t 
    class Program
    {
        static void Main(string[] args)
        {
            byte bytevalue = 250;           // 바이트 자료형은 원래 양의 정수 타입
            sbyte bytesvalue = -120;        // 음수, 양수
            int invalue = 123456789;
            uint usignedintval = 3876543210;
            long longvalue = 12345678987654;
            Console.WriteLine("값은 \t {0} {1} {2} {3} {4}", bytevalue, bytesvalue, invalue, usignedintval, longvalue);
            // cf) int uint
            // byte ubyte(X) sbyte(O)

            float fvalue = 3.1415f;
            double dvalue = 3.1415;
            decimal dmvalue = 3.1415m;
            Console.WriteLine("실수값은  \n {0} {1} {2}", fvalue, dvalue, dmvalue);

            //int maxvalue = 2300000000;
            int maxvalue = int.MinValue;
            maxvalue--;

            Console.WriteLine(maxvalue);

        }
    }
}





// 자료형
// var num = "abcdef";
// Console.WriteLine(num);
// var num2 = 1234;
// Console.WriteLine(num2);

// 정수                              c            c#
// int : -21억 ~ 21억             4 byte          "
// long : -21억 ~ 21억            4 byte          8 byte (21억 이상의 큰수) => long long
// short : -32768 ~ 32767, 0      2 byte          "
// char : -128 ~ 127, 0           1 byte          "
// long long                      8 byte          x
// byte : 0 ~ 255                 1 byte          "

// 자료형에서 c#만의 특징
// unsigned int                                 uint
// unsigned long                                ulong
//                                              u + 자료형 => unsigned 자료형 타입


// 실수
// float         c                               소수점 3자리수 정밀도
// double        c                               소수점 8자리수 정밀도
// c# 에서 쓰이는 실수표현
// decimal         double보다 훨씬 더 정밀한 자료형
// user    -    float
// com    -    double
// 3.14159      double
// 실수 자료형타입을 표시
// 3.14159f     => float
// 3.14159m     => decimal