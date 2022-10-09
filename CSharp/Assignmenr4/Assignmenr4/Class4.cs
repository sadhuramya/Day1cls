using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Assignment4
{
    public class Scholarship
    {
        public static int Totalmarks;
        public static float fees;
        public int Amount;
        public float Merit(int m, float f)
        {



            if (m >= 70 && m <= 80)
            {
                Amount = 20 * Convert.ToInt32(f) / 100;

            }
            if (m >= 80 && m <= 90)
            {
                Amount = 30 * Convert.ToInt32(f) / 100;
            }
            if (m > 90)
            {
                Amount = 50 * Convert.ToInt32(f) / 100;
            }
            return Amount;



        }
        public static void Main(string[] args)
        {
            Console.WriteLine("please enter Marks : ");
            Totalmarks = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter fees");
            fees = Convert.ToInt32(Console.ReadLine());
            Scholarship sp = new Scholarship();
            float feess = sp.Merit(Totalmarks, fees);
            Console.WriteLine("Your scholarship is : " + fees);
            Console.Read();
        }
    }
}