using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project01     // 작업영역 (다른 영역에 기능을 정의)
{
    class Program
    {
        static void Main(string[] args)
        {
            // 화면에 문자열 및 데이터 출력
            Console.Write("seokhwan  ");   // 문자열 출력
            //printf("seokhwan  ")



            Console.WriteLine(001);         // 숫자 출력
            Console.WriteLine("박석환 111");
            //printf("seokhwan  \n")


            // ctrl + shift + b - 컴파일 후 exe 파일 생성
            // 데이터와 문자열을 같이 출력
            Console.WriteLine("가나다라" + 12345);
            Console.WriteLine("abcd {0} {1} {2}" , 98765, "defg", 13579);
            Console.WriteLine("abcd " + 98765 + " defg " + 13579);
            Console.WriteLine("펜" + "파인애플" + "애플" + "펜");


            // 절차지향언어(c) - 정의부, 연산부가 구분되야함
            // 정의
            // 연산, 메서드

            // 객체지향언어 - 필요할때 마다 데이터 정의
            int num = 333;
            Console.WriteLine(num);

        }
    }
}
