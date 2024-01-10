using System.Collections.Generic;

class ShoppingCart
{
    private Dictionary<Product, int> products = new Dictionary<Product, int>();

    public void AddProduct(Product product, int quantity)
    {
        if (products.ContainsKey(product))
        {
            products[product] += quantity;
        }
        else
        {
            products[product] = quantity;
        }
    }

    public decimal CalculateTotal()
    {
        decimal total = 0;
        foreach (var kvp in products)
        {
            total += kvp.Key.Price * kvp.Value;
        }
        return total;
    }
}
