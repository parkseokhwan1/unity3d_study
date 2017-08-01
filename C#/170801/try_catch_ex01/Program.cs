using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 예외처리 (Exception)
// => 프로그램 실행중에 일어나게 되는 오류를 말하며
// 이러한 오류를 대응하는 코드를 예외처리라 한다.

// try - catch - throw - finally
// try : 예외가 일어날지도 모르는 영역을 블록화 시키기.
// catch  : 예외(오류)가 났을때, 오류의 종류와 처리를 담당하는 부분
// finally : 예외와 관계없이 처리되는 부분
// throw : 의도적으로 예외 상황을 만들어서 강제로 catch 문을 실행하게 만드는것
/*
    try
    {
        // 오류가 날지도 모르는 부분

        // 예외상황을 만들때
        throw 예외코드;
    }
    catch
    {
        // 예외상황이 발생했을때 처리
    }
    finally
    {
        // 예외가 있던 없던 처리되는 부분
    }
*/

class calc
{
    public void devide(int x, int y)
    {
        int z;
        try
        {
            z = x / y;      // 0으로 나눌수 없다
            // 에러가 발생되면 그때 catch 구문 실행
            // 강제로 예외상황을 만들기
            if (x == 0) // 상태에 맞추어
            {
                Exception e1 = new Exception("값이 0이어서");
                //e1.Message = "값이 0이어서";
                throw e1;   // 에러코드를 날림
            }
        }
        catch(Exception e)  // 상황별 에러데이터가 들어감.
        {
            Console.WriteLine(e.Message);
            Console.WriteLine("에러 상황");
        }
       
    }
}

namespace try_catch_ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            calc c = new calc();
            c.devide(5, 3);
            c.devide(30, 0);
            c.devide(0, 30);
        }
    }
}
