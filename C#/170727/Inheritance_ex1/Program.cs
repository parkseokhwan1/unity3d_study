﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
namespace Inheritance_ex1
{
    //상속 :  특정클래스를 기반으로 기능이 확장된 새로운 클래스를 만드는것
    //형식   class 파생클래스 : 기반클래스  (기반클래스가 미리 정의가되어 있어야함)
    class Book
    {
        public string title;
        public string genre;
        public void printBook()
        {
            Console.WriteLine("제목" + title);
            Console.WriteLine("제목" + genre);
        }
    }
    class Novel : Book
    {
        public string writer;
        public void PrintNov()
        {
            printBook();
            Console.WriteLine("저 자" + writer);
        }
    }
    class Magazine :Book
    {
        public int day;
        public void printMag()
        {
            printBook();
            Console.WriteLine("발매일" + day + "일");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Book myBook = new Book();
            myBook.title = "c#강의";
            myBook.genre = "컴퓨터";
            myBook.printBook();
            Console.WriteLine("-----");
            Novel nov = new Novel();
            nov.title = "개미";
            nov.genre = "판타지";
            nov.writer = "베르나르베르베르";

            Magazine mgz = new Magazine();
            mgz.title = "마이크로 소프트웨어";
            mgz.genre = "컴퓨터";
            mgz.day = 20;

            nov.PrintNov();
            Console.WriteLine("-----");
            mgz.printMag();
        }
    }
}
*/

class Base{
    private string var1 = "프라이빗형 변수";
    protected string var2 = "프로텍티드형 변수";//부모거
    public void BaseMathode(){
        Console.WriteLine("기반클래스 메서드임");
    }
}
class Sub : Base{
    public void Setdata(string sdata){
        var2 = sdata; //
    }
    public void SubMathode(){
        Console.WriteLine("파생클래스 메서드임");
    }
}
class Sub2 : Sub{
    public void AAA() {  
        var2 = "aaaa";
        //자료 메서드사용
        SubMathode();  
    }
    
}

//자료형앞 권한.제한 형식....
class nogive
{

    public int num;
}
sealed class giveme : nogive
{

}
class veerygive : giveme
{
}

class Program
{
    static void Main()
    {
        Sub psub = new Sub();
        psub.Setdata("상속받은 객체의 속성은? ");
        psub.BaseMathode();
        psub.SubMathode();
        //psub.var2 = "aaa";
    }
}
