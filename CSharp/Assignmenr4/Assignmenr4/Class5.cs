
using System;

namespace Assignment4
{
    class String
    {
        public static void Main()
        {

            string str = "Ramya"; 
            Console.WriteLine("The number of Occurences of a String" +  " " + str + " is :");
            char ch = 'R';

            int count = 0;
            foreach (char s in str)
            { if (s == ch)
               
                { count++; } 

            }

            Console.WriteLine(count); 
            Console.ReadLine();
        }
    }
}

