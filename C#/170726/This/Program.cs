using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This
{
    class Employee
    {
        private string Name;
        private string Position;

        public void Setname(string Name)
        {
            this.Name = Name;
        }

        public string GetName()
        {
            return Name;
        }

        public void SetPosition(string Position)
        {
            this.Position = Position;
        }

        public string GetPosition()
        {
            return this.Position;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee pooh = new Employee();
            pooh.Setname("Pooh");

            Employee tigger = new Employee();
            tigger.Setname("Tiger");
            tigger.SetPosition("Cleaner");
            Console.WriteLine("{0} {1}", tigger.GetName(), tigger.GetPosition());
        }
    }
}
