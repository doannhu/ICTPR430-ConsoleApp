using System;
using System.Collections.Generic;
using System.Text;

namespace ICTPR430_ConsoleApp
{
	class Trucks : Vehicles
	{
		private int loadCap;
		private int axles;
		private int wheels;
		public Trucks(string registrationNumber, string make, string model, int kilometerDriven, Drivers driver, int loadCap, int axles, int wheels) : base(registrationNumber, make, model, kilometerDriven, driver)
		{
			this.axles = axles;
			this.loadCap = loadCap;
			this.wheels = wheels;
		}
		public void DisplayTruckDetails() { Console.WriteLine("The max load capacity is " + this.loadCap + ". axles are " + this.axles + ". number of wheels is " + this.wheels); }
		public override void DisplayAll() {Console.WriteLine("Truck - Show all: \n"); DisplayTruckDetails(); base.DisplayAll();  }
	}
}
