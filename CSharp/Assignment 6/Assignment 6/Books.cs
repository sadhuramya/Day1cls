using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*1. Create a class called Books with BookName and AuthorName members. 
 * Instantiate the class through constructor and also write a method Display() to display the details. 
 * Create an Indexer of Books Object to store 5 books in a class called BookShelf.
 Using the indexer method assign values to the books and display the same.
*/

namespace Assignment6
{

        class Books
        {
            string Bookname;
            string Authorname;

            public Books(string Bookname, string Authorname)
            {
                this.Bookname = Bookname;
                this.Authorname = Authorname;
            }

            public void Display()
            {
                Console.WriteLine(Bookname + " " + "is in :" + Authorname);
            }
        }
        class BookShelf
        {
            Books[] bkobj = new Books[5];

            public Books this[int pos]
            {
                get { return bkobj[pos]; }
                set { bkobj[pos] = value; }
            }

            static void Main()
            {
                BookShelf bs = new BookShelf();
                bs[0] = new Books("The India Story", "Bimal Jalal");
                bs[1] = new Books("A Place Called Home", "Preeti Shenoy");
                bs[2] = new Books("Lal Salam", "Smriti Irani");
                bs[3] = new Books("Queen of Fire", "Devika Rangachari");
                bs[4] = new Books("The Maverick Effect", " Harish Mehta");
                for (int i = 0; i < 5; i++)
                {
                    bs[i].Display();
                }

                Console.Read();
            }
        }
    }


