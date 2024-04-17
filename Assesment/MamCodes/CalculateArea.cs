using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*WAP to show the overloading of Calculate method which is calculate the area of rectangle,
 * area of rectangle,area of circle, area of square use the menu driven concept here*/
namespace Assesment.MamCodes
{
    public class CalculateArea
    {
        static int Calculate(int length, int width)
        { 
           return length*width;
        }

        static double Calculate(double basel, double height)
        {
            return 0.5 * basel * height;
        }

        static double Calculate(double radius)
        { 
        return 3.14*radius*radius;
        }

        static float Calculate(float side1, float side2)
        {
            return side1 * side2;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1.Calculate area of rectangle");
                Console.WriteLine("2.Calculate area of triangle");
                Console.WriteLine("3.Calculate area of circle");
                Console.WriteLine("4.Calculate area of square");
                Console.WriteLine("5.Exit");

                Console.WriteLine("Enter your choice");
                int choice=Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        //console.writeline("enter length");
                        //int length = convert.toint32(console.readline());
                        //console.writeline("enter width");
                        //int width = convert.toint32(console.readline());
                        Console.WriteLine("Area of rectangle: "+Calculate(20, 30));
                        break;

                    case 2:
                        Console.WriteLine("Enter basel");
                        double basel = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter height");
                        double height = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Area of triangle: " + Calculate(basel, height));
                        break;

                    case 3:
                        Console.WriteLine("Enter radius");
                        double radius = Convert.ToDouble(Console.ReadLine());
                        
                        Console.WriteLine("Area of circle: " + Calculate(radius));
                        break;

                    case 4:
                        Console.WriteLine("Enter side1");
                        float side1 = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine("Enter side2");
                        float side2 = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine("Area of square: " + Calculate(side1, side2));
                        break;

                    case 5:
                        Console.WriteLine("Exit");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;

                }
            }
        }
    }
}
