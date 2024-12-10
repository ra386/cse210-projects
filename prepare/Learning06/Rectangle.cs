using System;

namespace Objects
{
    public class Rectangle : Shapes
    {
        private double _length;
        private double _width;

        public Rectangle( string Color, double Length, double Width) : base (Color)
        {
            _length = Length;
            _width = Width;

        }

        public double GetLength()
        {
            return _length;
        }

        public void SetLength(double Length)
        {
            _length = Length;
        }

        public double GetWidth()
        {
            return _width;
        }

        public void SetWidth(double Width)
        {
            _width = Width;
        }

        public override double GetArea()
        {
            return _length * _width;
        }
    }
}