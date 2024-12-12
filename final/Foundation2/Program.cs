using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address address1 = new Address("935 Grubbs St", "Center Point", "IA", "USA");
        Address address2 = new Address("189 Buckingham Ln", "Northampton", "England", "United Kingdom");

        // Create customers
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        // Create products
        Product product1 = new Product("Widget", "A001", 3.50m, 10);
        Product product2 = new Product("Gadget", "A002", 5.00m, 5);
        Product product3 = new Product("Doohickey", "A003", 7.25m, 2);
        Product product4 = new Product("Baseball", "A004", 4.50m, 4);
        Product product5 = new Product("Board Game", "A005", 10.99m, 3);


        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product5);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        // Display order details
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}\n");

        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}\n");
    }
}
