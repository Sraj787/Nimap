﻿namespace ConstructorExample
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();

            var order = new Order();
            
            customer.Orders.Add(order);
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
        }
    }
}
