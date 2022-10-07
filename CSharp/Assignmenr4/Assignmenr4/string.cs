using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{

    class Program1

    {
        static void Main(string[] args)

        {

            string name = "welcome to dotnet training";

            while (name.Length > 0)

            {

                Console.Write(name[0] + " : ");

                int count = 0;

                for (int j = 0; j < name.Length; j++)

                {

                    if (name[0] == name[j])

                    {

                        count++;

                    }

                }

                Console.WriteLine(count);

                name = name.Replace(name[0].ToString(), string.Empty);

            }

            Console.ReadLine();
        }

    }

}
