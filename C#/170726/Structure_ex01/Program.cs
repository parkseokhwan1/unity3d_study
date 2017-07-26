using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

struct Player
{
    public int hp;
    public int mp;
    public int sp;

    public Player(int hp, int mp, int sp)
    {
        this.hp = hp;
        this.mp = mp;
        this.sp = sp;
    }

    public override string ToString()
    {
        return string.Format("HP : {0}, MP : {1}, SP : {2}", hp, mp, sp);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Player p01;
        p01.hp = 500;
        p01.mp = 80;
        p01.sp = 100;

        Console.WriteLine(p01.ToString());

        Player p02 = new Player(600, 220, 110);
        Player p03 = p02;
        p03.hp = 1000;

        Console.WriteLine(p02.ToString());
        Console.WriteLine(p03.ToString());
    }
}

