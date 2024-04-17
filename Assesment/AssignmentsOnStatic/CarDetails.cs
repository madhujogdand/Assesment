using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*1.Create a class Car with String model and int totalCarSold as static variable in main() method.
2.Change the value of variable by class name then Print it.
3.Create two object of Car class and change value of static variable by 1st object and print it by 
accessing 2nd object.
*/
namespace Assesment.AssignmentsOnStatic
{
    public class Car
    {
        private string model;
        private static int totalCarSold=0;

        public Car(string model)
        {
            this.model = model;
            totalCarSold++;
        }
        public string GetModel()
        {
            return model;
        }

        public static int GetTotalCarSold()
        {
            return totalCarSold;
        }
    }
    public class CarDetails
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Toyota");
            Car car2 = new Car("Honda");

            
            Console.WriteLine("Total cars sold: " + Car.GetTotalCarSold());
        }
    }
}
