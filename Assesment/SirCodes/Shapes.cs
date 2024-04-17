using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment.SirCodes
{
    abstract public class Shape
    {
        public abstract void CalculateArea();
        public void Display()
        {
            Console.WriteLine("We can display various shapes");
        }
    }

    public class Circle : Shape
    {
        private int radius;
        private double result;
        public const double pi= 3.14;
        public Circle(int radius)
        {
            this.radius = radius;
        }
        public override void CalculateArea()
        {
            result = pi * radius * radius;
        }

        public string Print()
        {
            return $"Area of circle is {result}";
        }
    }

    public class Rectangle : Shape
    {
        private int length;
        private int width;
        private int area;

        public Rectangle(int length, int width)
        {
            this.length=length;
            this.width=width;
        }
        public override void CalculateArea()
        {
            area= length * width;
        }

        public string Print()
        {
            return $"Area of Rectangle is {area}";
        }
    }
    public class Shapes
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(5);
            c.CalculateArea();
            Console.WriteLine(c.Print());


            Rectangle rect=new Rectangle(8,5);
            rect.CalculateArea();
            Console.WriteLine(rect.Print());
        }
    }
}
