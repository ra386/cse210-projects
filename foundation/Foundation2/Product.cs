public class Product
{
    private string productName;
    private int productId;
    private double productPrice;
    private int productQty;

    public Product(string productName, int productId, double productPrice, int productQty)
    {
        this.productName = productName;
        this.productId = productId;
        this.productPrice = productPrice;
        this.productQty = productQty;
    }

    public double CalculateTotalCost()
    {
        return productPrice * productQty;
    }

    public string GetName()
    {
        return productName;
    }

    public int GetQty()
    {
        return productQty;
    }
    public int GetId()
    {
        return productId;
    }
}