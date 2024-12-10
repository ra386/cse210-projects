using System;
using Objects;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning06 World!");

        List<Shapes> Shp = new List<Shapes>();

        

       Square square1 = new Square("blue", 7);
        
      
       Shp.Add(square1);

       Rectangle rectangle1 = new Rectangle("green", 5, 10);
       
       Shp.Add(rectangle1);

       
       Circle circle1 = new Circle("cyan", 7);
    
       Shp.Add(circle1);

       foreach ( Shapes S in Shp)
       {
        string Color = S.GetColor();
        double area = S.GetArea();
        Console.WriteLine($"The color {Color} has an area of {area} ");
       }

       




       
        
    }
}