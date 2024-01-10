class Order
{
    public int OrderId { get; }
    public ShoppingCart ShoppingCart { get; }

    public Order(int orderId, ShoppingCart shoppingCart)
    {
        OrderId = orderId;
        ShoppingCart = shoppingCart;
    }
}
