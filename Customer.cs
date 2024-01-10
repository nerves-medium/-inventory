using System;
using System.Collections.Generic;

class Customer
{
    private string Name;
    private Dictionary<int, Order> Orders = new Dictionary<int, Order>();

    public Customer(string name)
    {
        Name = name;
    }

    public int PlaceOrder(ShoppingCart shoppingCart)
    {
        int orderId = Orders.Count + 1;
        Order order = new Order(orderId, shoppingCart);
        Orders[orderId] = order;
        return orderId;
    }

    public void DisplayOrder(int orderId)
    {
        if (Orders.ContainsKey(orderId))
        {
            Order order = Orders[orderId];
            Console.WriteLine($"Order ID: {order.OrderId}");
            Console.WriteLine("Products:");
            foreach (var kvp in order.ShoppingCart.Products)
            {
                Console.WriteLine($"{kvp.Key.Name}: {kvp.Value}");
            }
            Console.WriteLine($"Total: ${order.ShoppingCart.CalculateTotal()}");
        }
        else
        {
            Console.WriteLine($"Order with ID {orderId} not found.");
        }
    }
}
