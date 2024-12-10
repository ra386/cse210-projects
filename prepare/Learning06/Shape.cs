using System;
using System.Security.Authentication;

namespace Objects
{
    public abstract class Shapes
    {
        private string _Color;

        public Shapes (string Color)
        {
            _Color = Color;
        }

        public string GetColor()
        {
            return _Color;
        }

        public void SetColor(string Color)
        {
            _Color = Color;

        }

        public abstract double GetArea();

    }
}