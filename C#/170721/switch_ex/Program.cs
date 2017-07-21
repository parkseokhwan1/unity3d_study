using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_ex
{
    class Program
    {
        enum Animal /* (: Int32) */ { mouse, cat, bird, dog = 100, pig = 200, lion }
        static void Main()
        {
            Animal a;
            a = Animal.dog;
            Console.WriteLine(Animal.bird);
            Console.WriteLine(Animal.bird);
            Console.WriteLine((int)Animal.pig);
            Console.WriteLine((int)a + " animal " + a);
        }
    }
}




/*
           int num = 23;
           num = num % 5;
           switch(num)
           {
               case 1:
                   Console.WriteLine("나머지는 1");
                   break;
               case 2:
                   Console.WriteLine("나머지는 2");
                   break;
               case 3:
                   Console.WriteLine("나머지는 3");
                   break;
               case 4:
                   Console.WriteLine("나머지는 4");
                   break;
               default:
                   Console.WriteLine("나머지는 0");
                   break;
           }
           */

/*
int a = 65;
if (a >= 90)
{
    Console.WriteLine('A');
}
else if (a>=80 && a<90)
{
    Console.WriteLine('B');
}
else
{
    Console.WriteLine('C');
}
*/



// 상수
// 변수 선언과 비슷하지만 앞에 const 키워드를 붙임
// 생성과 동시에 초기화
// 생성후 초기화 안됨
// 생성후 값 변경 안됨
// const int A_Score = 9;
// const int AP_Score = 10;

/*
int score = 75;
switch (score / 10)
{
    case AP_Score:
    case A_Score :
        Console.WriteLine('A');
        break;
    case 8 :
        Console.WriteLine('B');
        break;
    default:
        Console.WriteLine('C');
        break;
}
*/





/*

        // c 언어는 자료형들에 들어가는 데이터는 값으로 들어감
        // enum 의 경우는 정수 값이 들어감
        enum GameState { Load = 1, Intro, Game, Option = 7, Exit }
        static void Main(string[] args)
        { 
            // 열거
            // 멤버변수별로 자동으로 값이 세팅되는 자료형
            // 형식
            // enum 자료형이름 { 파라미터(키워드) } 해당키워드에 값이 자동으로 세팅
            //                                      0부터 세팅됨
            // 변수선언
            // 열거자료형 변수
            // 변수에 값 셋팅, 혹은 비교시
            // 변수 = 열거형.파라미터; 파라미터가 가리키고 있는 숫자값이 변수에 들어감
            GameState state;            // 변수
            state = GameState.Game;     // 셋팅
            Console.WriteLine(state);
            Console.WriteLine( (int)GameState.Load );
            Console.WriteLine( (int)GameState.Exit );


            switch (state)
            {
                case GameState.Load:
                    Console.WriteLine("Load");
                    break;
                case GameState.Game:
                    Console.WriteLine("Game");
                    break;
                case GameState.Exit:
                    Console.WriteLine("Exit");
                    break;
                case GameState.Intro:
                    break;
            }
            
        
        }

    */
