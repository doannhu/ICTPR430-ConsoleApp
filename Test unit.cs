using System;
using System.Collections.Generic;
using System.Text;

namespace ICTPR430_ConsoleApp
{
    class Test_unit
    {
        public void TestCar(Cars car1, Cars car2)
        {
            car1.DisplayVehicleDetails();
            car1.DisplayCarDetails();
            car1.DisplayAll();
            Console.WriteLine("**********************");
            car2.DisplayVehicleDetails();
            car2.DisplayCarDetails();
            car2.DisplayAll();
            Console.WriteLine("**********************");
        }
        public void TestTruck(Trucks truck1, Trucks truck2)
        {
            truck1.DisplayVehicleDetails();
            truck1.DisplayTruckDetails();
            truck1.DisplayAll();
            Console.WriteLine("**********************");
            truck2.DisplayVehicleDetails();
            truck2.DisplayTruckDetails();
            truck2.DisplayAll();
            Console.WriteLine("**********************");
        }
    }
}
