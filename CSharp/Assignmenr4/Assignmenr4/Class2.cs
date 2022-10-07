using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Doctor
    {
        public int Regno { get; set; }
        public string Name { get; set; }
        public int FeesCharged { get; set; }


        public Doctor(int Rgn, string Nm, int Fechgd)
        {
            Regno = Rgn;
            Name = Nm;
            FeesCharged = Fechgd;

        }

        public void Display()
        {
            Console.WriteLine("enter the register number :" + Regno);
            Console.WriteLine("enter the name :" + Name);
            Console.WriteLine("enter the feecharged :" + FeesCharged);
            Console.Read();


        }

        static void Main(string[] args)

        {
            Doctor dc = new Doctor(123, "ramya", 10000);
            dc.Display();
            Console.Read();
        }
    }
}
