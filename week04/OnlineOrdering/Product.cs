
using System;
using System.Numerics;

class Product
{
    public string _name;
    public int _productId;
    private int _price;
    private int _quantity;

    public Product(string name, int productId, int price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }
    public int TotalCost()
    {
        return _price * _quantity;
    }
    
}