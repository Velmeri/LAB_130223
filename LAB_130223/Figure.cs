using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_130223
{
    abstract class Figure
    {
        public abstract double CalculateArea();
    }

    class Rectangle : Figure
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double CalculateArea()
        {
            return Width * Height;
        }
    }

    class Circle : Figure
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    class Triangle : Figure
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public Triangle(double @base, double height)
        {
            Base = @base;
            Height = height;
        }

        public override double CalculateArea()
        {
            return 0.5 * Base * Height;
        }
    }

    class Trapezium : Figure
    {
        public double UpperBase { get; set; }
        public double LowerBase { get; set; }
        public double Height { get; set; }

        public Trapezium(double upperBase, double lowerBase, double height)
        {
            UpperBase = upperBase;
            LowerBase = lowerBase;
            Height = height;
        }

        public override double CalculateArea()
        {
            return 0.5 * (UpperBase + LowerBase) * Height;
        }
    }
}
