using System;

public class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer)
    {
        products = new List<Product>();
        this.customer = customer;
    }
    public void AddProduct(Product product)
    {
        products.Add(product);

    }
    public double CalculateTotalCost()
    {
        double TotalCost = 0;

        foreach(var product in products)
        {
            TotalCost += product.CalculateTotalCost();
        }

        if (customer.InUsa())
        {
            TotalCost += 5;
        }
        else
        {
            TotalCost += 35;
        }
        return TotalCost;
    }
     
     public string PackageLabel()
     {
        string Label = "Packaging Label";
        foreach(var product in products)
        {
            
            Label += $"{product.GetName()} (ID: {product.GetId()})\n";
        }
        return Label;
     }

     public string ShippingAdd()
     {
        return $"ShippingLabel: {customer.GetName()} {customer.GetAddress().FullAddress()}";
     }

    
}