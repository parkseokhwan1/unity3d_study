using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MyClass
{
    public int data1;       // 생성자 X
    // 컴파일러에서 생성자를 만들고 값을 0으로 초기화
    public MyClass Clonedata()
    {
        MyClass tempdata = new MyClass();   // 할당
                                            // 클래스내부에 클래스가 있는 형태
                                            /*
                                             |       data1                                      | MyClass
                                             |    [              ]clonedata ()                  |
                                             |    [| data1   |tempdata ]                        |
                                             */
        tempdata.data1 = this.data1;
        return tempdata;
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyClass source;
        MyClass copy;
        source = new MyClass();     // 해당 클래스 크기만큼 공간 만들고, 생성자 호출
        copy = source;      // int a = 3;   int b = a;    a[3]  b[3]
        // 영역을 공유함 => 소스가 가리키는 데이터 영역의 정보를 copy 에도 알려줌
        // 원본 사본    data1   =>  0
        // copy.data1 = 123;   // copy가 가르키는 영역에 내부 데이터를 바꾼다.
        // Console.WriteLine(source.data1);

        copy = source.Clonedata();
        copy.data1 = 123;
        source.data1 = 486;
        Console.WriteLine(copy.data1 + " " + source.data1);

    }
}

