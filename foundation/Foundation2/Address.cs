using System;

public class Address
{
    private string StreetAdd;
    private string City;
    private string Country;

    public Address(string StreetAdd, string City, string Country)
    {
        this.StreetAdd = StreetAdd;
        this.City = City;
        this.Country = Country;

    }

    public bool InUsa()
    {
        return Country == "USA";
    }

    public string FullAddress()
    {
          return $"{StreetAdd}, {City}, {Country}";
    }
}