using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator01
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = "3.14";
            float dat = float.Parse(num);      //  1
            double dat2 = Convert.ToDouble(num);
            Console.WriteLine(dat2);
            Console.WriteLine((float)dat2);

            int a = 33;
            double rest = Convert.ToDouble(a);
            Console.WriteLine(rest);


        }
    }
}




//Console.WriteLine("<오칙연산 (+, -, *, /, %)>");
//            int num = 32767;
//int val = num;

//// 1의 자리 7
//int result = val % 10;      // 32767
//                            //Console.WriteLine("1의 자리 : " + (num % 10) / 1);
//Console.WriteLine(result);

//            // 6   
//            //Console.WriteLine("10의 자리 : " + (num % 100) / 10);
//            val = val / 10;             // 3276
//            result = val % 10;
//            Console.WriteLine(result);

//            // 7  
//            //Console.WriteLine("100의 자리 : " + (num % 1000) / 100);
//            val = val / 10;             // 327
//            result = val % 10;
//            Console.WriteLine(result);

//            // 2
//            //Console.WriteLine("1000의 자리 : " + (num % 10000) / 1000);
//            val = val / 10;             // 32
//            result = val % 10;
//            Console.WriteLine(result);

//            // 3   => 각각의 자리수 출력
//            //Console.WriteLine("10000의 자리 : " + (num % 100000) / 10000);
//            val = val / 10;             // 3
//            result = val % 10;
//            Console.WriteLine(result);

//            Console.WriteLine("=====================================================");

// 대입 : int num = 333;

// 증감
// int hp = 50;
// Console.WriteLine(hp++);
// Console.WriteLine(++hp);
// Console.WriteLine(hp--);
// Console.WriteLine(--hp);
// hp += 10; => hp = hp + 10;
// hp /= 10; hp = hp / 10 (0으로 나누거나 값이 0이 되지 않도록)

// 비교 => 결과는 0, 1이다 => true, false
// int age = 13;
// (age > 10) 
// >, <, >=, <=, !=, ==

// 논리 : and, or, not
// &&(논리곱)     ||(논리합)     !(논리부정) : 값(참, 거짓의 관계) 논리를 체크
// & ,            |            : 메모리(비트) 논리를 체크
// 교집합       합집합          여집합
// 공통(그리고)   또는           아니다
// 공통 만족시                   현재부정
// (a>10) && (a<50)         a = 34 : 참 , a = 9 : 거짓
// (a == 1) || (a == 100)   a = 1 : 참 , a = 33 : 거짓
// !(a == 100)              a = 33 : 참 
// cf) a = 3;
// ( (a == 5) || (a = 7) )  : 참  -> 할당식은 참으로 간주

/*
int a = 3, b = 4;
bool x, y;
x = (a < 0);
y = (b > 0);
Console.WriteLine((a == 3) && (b == 3));
Console.WriteLine(x || y);

Console.WriteLine(2 * 8 - 6 / 2);
Console.WriteLine(2 * (8 - 6) / 2);
Console.WriteLine(1 - 2 + 3);
Console.WriteLine(1 - (2 + 3));

// 형변환 cast 연산자
// => 변수 앞에 ()를 넣고 자료형을 넣으면 강제로 형변환이 일어남
Console.WriteLine((float)(3 / 2));
Console.WriteLine(3 / (float)2);
Console.WriteLine((float)3 / (float)2);
Console.WriteLine((float)3 / 2);
*/





/*
            // 삼항연산자
            // 조건식의 값에 따라 계산식 선택
            // if - else : 비슷한 구조
            // 차이점 : 각 조건별 1줄로 제약
            // 형식
            // 값 ? 로직1 : 로직2;
            // 0, 1 값 => 값을 비교해서 참(1)일때는 로직1 수행
            //                         거짓(0)일때는 로직2 수행
            //(조건식) ? 세팅1 : 세팅2;
            string right = "정답";
            string wrong = "오답";
            bool value;

            value = true;
            string answer = value ? right : wrong;
            Console.WriteLine("값은 =>" + answer);

            value = false;
            answer = value ? right : wrong;
            Console.WriteLine("값은 =>" + answer);

            string answer2;
            value = true;
            answer2 = value ? "alright" : "very wrong";
            */
