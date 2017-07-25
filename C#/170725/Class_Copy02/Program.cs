using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
  
class BookData
{
    public string m_title;
    public int    m_price;
    public BookData(string t, int p)
    {
        m_title = t;
        m_price = p;
    }
    public void print()
    {
        Console.WriteLine("제목 : " + m_title);
        Console.WriteLine("가격 : " + m_price);
    }
    // 객체를 인자로 받는 생성자 => 내부의 데이터 셋팅을 위해
    // 복사 생성자 (받은 객체의 정보를 복사해서 현재 객체에 넣기 때문에)
    public BookData(BookData temp)      // 저장공간을 만든것? X, 자료형 받음
    {
        this.m_price = temp.m_price;    // 받은 자료형 수정 X, 값을 넣어줌
        this.m_title = temp.m_title;
        // temp 내부 데이터의 변경 X
    }
}

class Program
{
    static void Main()
    {
        BookData source = new BookData("트와일라잇", 19800);
        source.print();
        BookData copy = new BookData(source);
        copy.print();
        source.m_price = 21300;
        source.print();
        copy.print();
    }
}

