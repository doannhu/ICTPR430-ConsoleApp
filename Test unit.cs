using System;
using System.Collections.Generic;
using System.Text;

namespace ICTPR430_ConsoleApp
{
    class Test_unit
    {
        //method to test outputs of car methods
        public void TestCar(Cars car1, Cars car2)
        {
            Console.WriteLine("For car1: *****");
            car1.DisplayVehicleDetails();
            car1.DisplayCarDetails();
            car1.DisplayAll();
            Console.WriteLine("**********************");
            Console.WriteLine("For car2: *****");
            car2.DisplayVehicleDetails();
            car2.DisplayCarDetails();
            car2.DisplayAll();
            Console.WriteLine("**********************");
        }
        //method to test outputs of truck methods
        public void TestTruck(Trucks truck1, Trucks truck2)
        {
            Console.WriteLine("For truck1: *****");
            truck1.DisplayVehicleDetails();
            truck1.DisplayTruckDetails();
            truck1.DisplayAll();
            Console.WriteLine("**********************");
            Console.WriteLine("For truck2: *****");
            truck2.DisplayVehicleDetails();
            truck2.DisplayTruckDetails();
            truck2.DisplayAll();
            Console.WriteLine("**********************");
        }
    }
}
