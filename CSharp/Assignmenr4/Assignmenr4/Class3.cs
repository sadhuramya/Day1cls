using System;



namespace Assignment4
{
    class Customer
    {
         int Customerid;
        string Name;
        int Age;
         string City;
        long Phone;

        public Customer()
        {
          
        }
        public Customer(int  cstid, string name, int age, string cty, long phn) // Parameterized Constructor
        {
            this.Customerid = cstid;
            this.Name = name;
            this.Age = age;
            this.City = cty;
            this.Phone = phn;



        }



        public static void DisplayCustomer()
        {
            Customer customer1 = new Customer(1, "Ramya", 23, "skht", 9887346903);



            Console.WriteLine("Customer Id: {0}", customer1.Customerid);
            Console.WriteLine("Customer Name: {0}", customer1.Name);
            Console.WriteLine("Customer Age: {0}", customer1.Age);
            Console.WriteLine("Customer City: {0}", customer1.City);
            Console.WriteLine("Customer Phone: {0}", customer1.Phone);



            Console.ReadLine();
        }
         static void Main(string[] args)
        {
          DisplayCustomer();

        }
    }
}