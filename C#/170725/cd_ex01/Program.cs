using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Book
{
    public int price;
    public int num = 0;
    public string title;

    public Book()
    {
        price = num = 0;
        title = "";
    }

    public Book(string t, int p)
    {
        price = p;
        title = t;
    }

    public void printbook()
    {
        Console.WriteLine("제목" + title);
        Console.WriteLine("가격" + this.price);       // 현재 활성화된 내 객체를 참조함.
        // 클래스 키워드
        // this.클래스명 => 현재 내가 사용하고 있는 클래스 이름을 통해
        //                  객체를 제어한다
        Console.WriteLine("주문량" + num);
        Console.WriteLine("총합" + price*num);
    }
}

namespace cd_ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            Book magazine = new Book();
            Book book = new Book("해리포터_조엔롤링", 34000);
            book.num = 10;
            book.printbook();
        }
    }
}
