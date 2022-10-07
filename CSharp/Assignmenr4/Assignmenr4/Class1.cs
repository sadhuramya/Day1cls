using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program
    {
        string FirstName;
        String LastName;

        static void Display()
        {
            Console.WriteLine("Enter Your First Name :");
            string FirstName = Console.ReadLine();

            Console.WriteLine("Enter Your Last Name :");
            string LastName = Console.ReadLine();
            Console.WriteLine(" Your First Name is: " + FirstName.ToUpper());
            Console.WriteLine(" Your Last Name is: " + LastName.ToUpper());
            Console.Read();
        }

        static void Main(string[] args)
        {

            Display();
            Console.Read();

        }

    }
}
