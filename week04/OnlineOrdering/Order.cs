
using System;

class Order
{
    private Customer _customer;
    private List<Product> _products;
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public int CalculateTotal()
    {
        int totalProductCost = 0;
        foreach (var product in _products)
        {
            totalProductCost += product.TotalCost();
        }
        int shippingCost = _customer.IsInUSA() ? 5 : 35;
        return totalProductCost + shippingCost;
    }
    public string PackingLabel()
    {
        List<string> labels = new List<string>();
        foreach (var product in _products)
        {
            labels.Add($"{product._name} (ID: {product._productId})");
        }
        return string.Join("\n", labels);
    }
    public string ShippingLabel()
    {
        string shippingLabel = $"Name: {_customer._name}\n{_customer._address.GetFullAddress()}";
        return shippingLabel;
    }
}