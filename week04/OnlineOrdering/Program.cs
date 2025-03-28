
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        // Create Address instances
        Address address1 = new Address("123 Main St", "Los Angeles", "CA", "USA");
        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");

        // Create Customer instances
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        // Create Product instances
        Product product1 = new Product("Laptop", 101, 1000, 2);
        Product product2 = new Product("Mouse", 102, 25, 3);
        Product product3 = new Product("Keyboard", 103, 50, 1);

        // Create Order instances
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        // Get packing labels, shipping labels, and total prices
        Console.WriteLine("Order 1 Packing Label:\n" + order1.ShippingLabel());
        Console.WriteLine("\nOrder 1 Shipping Label:\n" + order1.ShippingLabel());
        Console.WriteLine("Order 1 Total Price: $" + order1.CalculateTotal());

        Console.WriteLine("\nOrder 2 Packing Label:\n" + order2.ShippingLabel());
        Console.WriteLine("\nOrder 2 Shipping Label:\n" + order2.ShippingLabel());
        Console.WriteLine("Order 2 Total Price: $" + order2.CalculateTotal());        
    }
}