using System;
using System.IO;

namespace ICTPR430_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] address1 = { "street", "111 King St", "city", "Melbourne", "state","Victoria","postCode","3000" };
            string[] address2 = { "street", "803 Glenferrie", "city", "Hawthorn", "state", "Victoria", "postCode", "3122" };
            string[] state1 = {"Victoria","NSW","Western Australia" };
            string[] state2 = { "Victoria", "Queensland", "Western Australia","South Australia","Northern Territory" };
            Drivers driver1 = new Drivers("1A2B3C", state1, "John", "Citizen", "0401234567", address1, 12);
            Drivers driver2 = new Drivers("111111", state2, "Aaron", "Sample", "0400000000", address2, 10);
            Cars car1 = new Cars("VINADC", "Vinfast","VF9",5000,driver1,"sedan","black","fabric",4);
            Cars car2 = new Cars("3DRC44", "Tesla", "Model3", 20000, driver2, "sedan", "white", "leather", 4);
            Trucks truck1 = new Trucks("HANOI123", "Mercedes", "Actros", 5000, driver1, 30000, 2, 6 );
            Trucks truck2 = new Trucks("HCMWIN", "Hyundai", "Pavise", 42000, driver2, 50000, 4, 10);
            Test_unit test = new Test_unit();
            //read and write file
            string[] myArray1 = {"driver's address: ", "street", "111 King St", "city", "Melbourne", "state", "Victoria", "postCode", "3000" };
            string[] myArray2 = {"licence: ", "1A2B3C", "name: ", "John", "Citizen","phone: ", "0401234567", "point: ", "12" };
            File.WriteAllText("C:\\temp\\csc.txt", String.Empty);
            File.AppendAllLines("C:\\temp\\csc.txt", myArray1);
            File.AppendAllLines("C:\\temp\\csc.txt", myArray2);
            string contents = File.ReadAllText("C:\\temp\\csc.txt");
            Console.WriteLine(contents);
            Console.WriteLine("---------------------------------------------------");
            //Before update, display all
            Console.WriteLine("\nBefore change: \n");
            test.TestCar(car1,car2);
            test.TestTruck(truck1, truck2);
            Console.WriteLine("---------------------------------------------------");
            //legal change
            car1.UpdateKilometer(200);// expect 5200
            car2.UpdateKilometer(500);// expect 20500
            truck1.UpdateKilometer(1000);// expect 6000
            truck2.UpdateKilometer(1500);//expect 43500
            car1.ChangeColor("red");
            car2.ChangeColor("red");
            driver1.UpdatePoint(3);//expect 9
            driver2.UpdatePoint(2);//expect 10
            // After change, display all            
            Console.WriteLine("\nAfter change: \n");
            test.TestCar(car1, car2);
            test.TestTruck(truck1, truck2);
            Console.WriteLine("---------------------------------------------------");
            //illegal change
            car1.UpdateKilometer(-100);// expect a message of error in valid number
            truck1.UpdateKilometer(-100);// expect a message of error in valid number
            driver1.UpdatePoint(9);// expect a message of License suspension is imminent
            driver2.UpdatePoint(12);// expect a message of You loose your licence
        }
    }
}
