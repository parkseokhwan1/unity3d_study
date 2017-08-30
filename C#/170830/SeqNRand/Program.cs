using System;
using System.IO;


namespace SeqNRand
{
    class Program
    {
        static void Main(string[] args)
        {
            Stream outSteam = new FileStream("a.dat", FileMode.Create);
            Console.WriteLine("Position : {0}", outSteam.Position);

            outSteam.WriteByte(0x01);
            Console.WriteLine("Position : {0}", outSteam.Position);

            outSteam.WriteByte(0x02);
            Console.WriteLine("Position : {0}", outSteam.Position);

            outSteam.WriteByte(0x03);
            Console.WriteLine("Position : {0}", outSteam.Position);

            outSteam.Seek(5, SeekOrigin.Current);
            Console.WriteLine("Position : {0}", outSteam.Position);

            outSteam.WriteByte(0x04);
            Console.WriteLine("Position : {0}", outSteam.Position);

            outSteam.Close();
        }
    }
}
