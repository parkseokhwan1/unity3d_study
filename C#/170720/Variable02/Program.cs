using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable2
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = 'a';           // unicode  //nbyte      // cf) c언어 : utf-8 => 1byte
            char b = '가';
            char c = '飛';
            Console.WriteLine(a + " " + b + " " + c);

            string strdata = "안녕하세요";
            Console.WriteLine(strdata);
            strdata = "123";
            Console.WriteLine(strdata);

            // 문자열을 숫자 데이터로 바꾸기
            int numdata = int.Parse(strdata);
            Console.WriteLine(numdata);
            strdata = "3.14";
            float numdata2 = float.Parse(strdata);
            Console.WriteLine(numdata2);

            // 계산
            // 수치데이터 -> 문자로 바꿈
            float result = 123.456f;   //가상으로 생각한 결과
                                       // 문자열로 변환
            // 1) 
            string strd = result.ToString();
            Console.WriteLine(strd);
            // 2)
            // "" : 문자열이지만 데이터는 없음 -> 빈문자열(NULL)
            string strd2 = "  " + result;
            Console.WriteLine(strd2);

            // 비만도 측정
            float heightA = 173f;
            float heightB = 170f;
            float kgA = 80f;
            float kgB = 65f;
            float bmiA = kgA / ( (heightA / 100) * (heightA / 100) );
            float bmiB = kgB / ( (heightB / 100) * (heightB / 100) );
            Console.WriteLine("남자 A의 비만도는 " + bmiA + " 입니다.");
            Console.WriteLine("여자 B의 비만도는 " + bmiB +" 입니다.");

        }
    }
}
