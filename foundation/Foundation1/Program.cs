using System;

public class Program
{
    public static void Main(string[] args)
    {
        // (string street, string city, string state, string country)
        Address address1 = new Address("35-46 alcala St", "Bogotá", "Cundinamarca", "Colombia");
        Address address2 = new Address("16-09 La gaviota St", "Ibague", "Tolima", "Colombia");

        // Create customers
        Customer customer1 = new Customer("Tatiana Rendon", address1);
        Customer customer2 = new Customer("Kleithin Alvarez", address2);

        // Create products
        Product product1 = new Product("Empanadas", "OR001", 16m, 2);
        Product product2 = new Product("Ice cream: cokes and cream", "OR002", 10m, 2);
        Product product3 = new Product("Coca-Cola", "OR003", 10m, 1);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);

        // Display order details
        DisplayOrder(order1);
        DisplayOrder(order2);
    }

    private static void DisplayOrder(Order order)
    {
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"\nTotal Cost: ${order.CalculateTotalCost():0.00}\n");
    }
}