using System;

 namespace Objects
 {
    public class Circle : Shapes
    {
        private double _raduis;

        public Circle( string Color, double Raduis) : base (Color)
        {
            _raduis = Raduis;

        }

        public double GetRaduis()
        {
            return _raduis;
        }

        public void SetRaduis(double Raduis)
        {
            _raduis = Raduis;
        }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(_raduis, 2) ;
        }
    }
 }