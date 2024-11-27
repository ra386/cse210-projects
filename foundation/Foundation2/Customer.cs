using System;


public class Customer
{
    private string Name;
    private  Address address;

    public Customer(string Name, Address address)
    {
        this.Name = Name;
        this.address = address;

    }

    public bool InUsa()
        {
            return address.InUsa();
        }

        public string GetName()
        {
            return Name;
        }

        public Address GetAddress()
        {
            return address;
        }
}

