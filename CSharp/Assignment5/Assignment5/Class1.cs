using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Create an console application to book train tickets. Create a Passanger class with (Name, Age) and 
    write a function called TicketBooking(int no_of_tickets) that takes no.of tickets to be booked. 
    If the no of tickets is > 2 per booking, raise an user defined exception, and 
    print "cannot book more than 2 tickets". Else Print  "Ticket Booked Successfully". 
    Add a Test class to call TicketBooking method by accepting all required details.*/


namespace Assignment5
{
    class Program
    {
        class Passanger
        {
            public string Name { get; set; }
            public int Age { get; set; }
            Ticket Ticket { get; set; }
            public Passanger(string name, int age)
            {
                Name = name;
                Age = age;
                Ticket = new Ticket();
            }
            public void TicketBooking(int tickets)
            {
                Ticket.Tickets = tickets;
                Console.WriteLine("Ticket Booked Successfully");
            }
        }


        class Ticket
        {
            public int tickets;
            public int Tickets
            {
                get => tickets;
                set
                {

                    if (value > 2)
                        throw new Exception("Cannot book more than 2 tickets");
                    else
                        tickets = value;
                }
            }


        }
        static void Main(string[] args)
        {
            Passanger psang = new Passanger("Ramya", 22);
            Console.Write("Enter the number of tickets :");
            psang.TicketBooking(int.Parse(Console.ReadLine()));
            Console.Read();
        }


    }
}