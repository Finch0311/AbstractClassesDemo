using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /* DONE
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* DONE
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // DONE Create a list of Vehicle called vehicles
            var vehicles = new List<Vehicle>();
            /*
             * DONE Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
            
             * DONE Set the properties with object initializer syntax
             */
            var car1 = new Car() 
            {
                HasTrunk = true,
                Year = "2011",
                Make = "Dodge",
                Model = "Challenger"
            };
            var motorcycle1 = new Motorcycle() 
            {
                HasSideCart = true,
                Year = "2007",
                Make = "Honda",
                Model = "Shadow"
            };
            Vehicle vehicle1 = new Car() 
            {
                Year = "2013",
                Make = "Ford",
                Model = "F-150"
            };
            Vehicle vehicle2 = new Motorcycle() 
            {
                Year = "2020",
                Make = "Indian",
                Model = "Scout"
            };
            /* DONE
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */
            vehicles.Add(car1 );
            vehicles.Add(motorcycle1);
            vehicles.Add(vehicle1);
            vehicles.Add(vehicle2);
            // DONE Call each of the drive methods for one car and one motorcycle
            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Year : {vehicle.Year}");
                Console.WriteLine($"Make : {vehicle.Make}");
                Console.WriteLine($"Model : {vehicle.Model}");
                vehicle.DriveVirtual();
                vehicle.DriveAbstract();
                Console.WriteLine();
                Console.WriteLine();
            }
            {

            }
            #endregion            
            
        }
    }
}
