using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
class calc1
{
    public int x;
    public calc1(int a, int b) {
        x = a + b;
    }
    
}
class calc2 : calc1
{

    //상속클래스 에서 원본의 생성자를 호출할때. base 키워드를 쓴다.                  
    public calc2(int c, int d):base(c,d) {
        x = c + d; 
    }
}
class Program
{
    static void Main(string[] args)
    {
        calc2 cx = new calc2(1, 2);
        Console.WriteLine(cx.x);
    }
}*/
/*
class A{
    public int a=3;
}
class B : A{
    public int a = 100;
    public void print(){
        Console.WriteLine(a);
        Console.WriteLine(base.a);  //부모객체의 접근 키워드..base
    }
}
class Program{
    static void Main() {
        B b = new B();
        b.print();
    }
}
*/
class A
{ }
class B : A
{
}

class Program
{
    static void Main()
    {
        int a = 36;
        string b = "책장";
        Console.WriteLine("is 결과" + a is long);
        Console.WriteLine("is 결과" + b is string);

        A aa = new B();
        B cc =  aa as B; //형변환   as 자료형변환  is 자료형체크
    }
}
