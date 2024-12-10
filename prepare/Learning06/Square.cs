using System;
namespace Objects
{
    public class Square : Shapes
    {
        private double _Side;

        public Square( string Color, double Side) : base (Color)
        {
            _Side = Side;

        }

        public double GetSide()
        {
            return _Side;
        }

        public void SetSide(double Side)
        {
            _Side = Side;
        }

        public override double GetArea()
        {
            return _Side*_Side;
        }
    }
}