
using System;

class Customer
{
    public string _name;
    public Address _address;
  
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }
}