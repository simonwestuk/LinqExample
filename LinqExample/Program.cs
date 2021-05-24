using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExample
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Customer> Customers = new List<Customer>();

            Customers.Add(new Customer("Simon", "West", "simon@gmail.com", new DateTime(1986, 7, 30), "0123456789"));

            Customers.Add(new Customer("Sally", "Wilkinson", "sally@gmail.com", new DateTime(1998, 2, 3), "0987654321"));

            Customers.Add(new Customer("John", "Smith", "jsmith@gmail.com", new DateTime(1968, 5, 4), "07654321882"));


            //LINQ Query
            try
            {
                Console.WriteLine("Enter search term:");
                int term = Convert.ToInt32(Console.ReadLine());

                foreach (var customer in Customers.Where(c => c.Dob.Year == term))
                {
                    Console.WriteLine(customer);
                }

            }
            catch (Exception)
            {

                Console.WriteLine("Needs to be a number.");
            }

            //If Statement
            try
            {
                Console.WriteLine("Enter search term:");
                int term = Convert.ToInt32(Console.ReadLine());

                foreach (var customer in Customers)
                {
                    if (customer.Dob.Year == term)
                    {
                        Console.WriteLine(customer);
                    }

                }
            }
            catch (Exception)
            {

                Console.WriteLine("Needs to be a number.");
            }

            Console.WriteLine("-------------------------------------------------------");
            //Starts with S, convert ToUpper to ensure we do not miss any name which may start with 's'
            foreach (var customer in Customers.Where(c => c.Fname.ToUpper().StartsWith("S")))
            {
                Console.WriteLine(customer);
            }

        }
    }
}
