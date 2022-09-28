using System;
namespace FirstDayProject
{
    public class PostiveNegative
    {
        public static void Main()
        {
            int num;



            num = Convert.ToInt32(Console.ReadLine());
            if (num >= 0)





                Console.WriteLine("{0} is a positive number.\n", num);



            else
                Console.WriteLine("{0} is a negative number. \n", num);
            Console.ReadKey();
        }
    }
}