using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Write a class Box that has Length and breadth as its members. 
 * Write a function that adds 2 box objects and stores in the 3rd. 
 * Create a Test class to execute the above.
*/
namespace CodeEaxm
{
        class Box
        {
          
            double length;
            double width;

            public void Acceptdetails()
            {
                length = 4.5;
                width = 3.5;
            }

            public double GetArea()
            {
                return length * width;
            }

            public void Display()
            {
                Console.WriteLine("Length: {0}", length);
                Console.WriteLine("Width: {0}", width);
                Console.WriteLine("Area: {0}", GetArea());
            }
        }

        
    }
