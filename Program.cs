using System;

class Program
{
    static void Main()
    {
        // Create products
        Product product1 = new Product("Laptop", 1000);
        Product product2 = new Product("Smartphone", 500);
        Product product3 = new Product("Headphones", 50);

        // Create a customer
        Customer customer = new Customer("John Doe");

        // Add products to the shopping cart
        ShoppingCart shoppingCart = new ShoppingCart();
        shoppingCart.AddProduct(product1, 2);
        shoppingCart.AddProduct(product2, 1);
        shoppingCart.AddProduct(product3, 3);

        // Place an order
        int orderId = customer.PlaceOrder(shoppingCart);

        // Display order details
        customer.DisplayOrder(orderId);
    }
}
