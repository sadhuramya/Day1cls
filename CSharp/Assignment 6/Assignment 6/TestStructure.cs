using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Create a structure 
struct Books 
   private string title;
   private string author;
   private string subject;
   private int book_id;
Include 2 methods called GetValues() and ShowValues() to accept and display details.
create a Class called TestStructures that invokes the above methods of the structure to accept and 
display the details of the book
*/

namespace Assignment6
{
    struct book
    {
        private string title;
        private string author;
        private string subject;
        private int book_id;
        public void getValues(string t, string a, string s, int id)
        {
            title = t;
            author = a;
            subject = s;
            book_id = id;
        }
        public void showValues()
        {
            Console.WriteLine("Title : {0}", title);
            Console.WriteLine("Author : {0}", author);
            Console.WriteLine("Subject : {0}", subject);
            Console.WriteLine("Book_id :{0}", book_id);
        }
    };
    public class TestStructure
    {
        public static void Main(string[] args)
        {
            book Book1 = new book();
            book Book2 = new book();

            Book1.getValues("A Passage to India", "E.M.Foster", "History", 123);
            Book2.getValues("A Woman's Life", "Guy de Maupassant", "Human Values", 101);


            Book1.showValues();
            Book2.showValues();

            Console.ReadKey();
        }
    }

}

