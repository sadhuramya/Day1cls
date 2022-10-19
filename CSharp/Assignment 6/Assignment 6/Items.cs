using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*4. Create a simple Stationery application to add items and display added items 
 * using Generic List collections*/


namespace Assignment6
{
    
        class Program
        {
            static void Main()
            {

                List<string> states = new List<string>();

                states.Add("ANDHRA PRADESH");
                states.Add("TELANGANA");

                List<string> newStates = new List<string>();

                newStates.Add("CHENNAI");
                newStates.Add("KARNATAKA");

                states.AddRange(newStates);

                Console.WriteLine("Accessing Generic List using For Each Loop");

                foreach (var item in states)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine("\nAccessing Generic List using For Loop");

                for (int i = 0; i < states.Count; i++)
                {
                    var element = states[i];
                    Console.WriteLine(element);
                }
                Console.WriteLine("\nAccessing Individual List Element by Index Position");
                Console.WriteLine($"First Element: {states[0]}");
                Console.WriteLine($"Second Element: {states[1]}");
                Console.WriteLine($"Third Element: {states[2]}");
                Console.WriteLine($"Fourth Element: {states[3]}");
                Console.ReadKey();
            }
        }
    }


