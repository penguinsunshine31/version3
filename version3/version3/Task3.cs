using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace version3
{
    public class Task3
    {
        class Figure
        {
            protected double Area;

            public Figure()
            {
                Area = 0;
            }

            public virtual double CalculateArea()
            {
                return Area;
            }
        }

        class Triangle : Figure
        {
            private double _base;
            private double _height;

            public double Base
            {
                get { return _base; }
                set { _base = value; }
            }

            public double Height
            {
                get { return _height; }
                set { _height = value; }
            }

            public double CalculateArea(double triangleBase, double height)
            {
                _base = triangleBase;
                _height = height;
                Area = _base * _height / 2;
                return Area;
            }
        }

        class Square : Figure
        {
            private double _sideLength;

            public double SideLength
            {
                get { return _sideLength; }
                set { _sideLength = value; }
            }

            public override double CalculateArea()
            {
                Area = _sideLength * _sideLength;
                return Area;
            }
        }

        public void task3 ()
        {

            Triangle triangle = new Triangle();
            double triangleArea = triangle.CalculateArea(6, 8);

            Square square = new Square();
            square.SideLength = 5;
            double squareArea = square.CalculateArea();

            Console.WriteLine("Area of Triangle: " + triangleArea);
            Console.WriteLine("Area of Square: " + squareArea);






        }









    }
}
