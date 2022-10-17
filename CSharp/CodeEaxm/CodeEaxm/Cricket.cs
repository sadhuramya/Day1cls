using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*1.Write a program to find the Sum and the Average points scored by the teams in the IPL. 
 * Create a Class called Cricket that has a function called Pointscalculation(int no_of_matches) that 
 * takes no.of matches as input and accepts that many scores from the user. The function should then 
 * display the Average and Sum of the scores. */


namespace CodeEaxm
{
    class Cricket
    {
        public void PointsCalculation(int no_of_matches)
        {
            double Sum = 0, Average = 0;
            Console.Write("Enter Num of Matches  Scored by each team : ");

            int n = Int32.Parse(Console.ReadLine());
            double[] numbers = new double[n];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Team  {0}: ", i + 1);
                numbers[i] = Convert.ToDouble(Console.ReadLine());
                Sum += numbers[i];
            }
            Average = Sum / numbers.Length;
            Console.WriteLine("The Sum is : " + Sum);
            Console.WriteLine("The Average is : " + Average);
             Console.ReadKey();

         }
        
        static void Main(string[] args)
        {
            Cricket ck = new Cricket();
            ck.PointsCalculation(1);
            Console.Read();
        }
    }
}

