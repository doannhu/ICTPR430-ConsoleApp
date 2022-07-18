using System;
using System.Collections.Generic;
using System.Text;

namespace ICTPR430_ConsoleApp
{
	class Cars : Vehicles
	{
		private string bodyType;
		private string colour;
		private string upholstery;
		private int numberOfDoors;
		public Cars(string registrationNumber, string make, string model, int kilometerDriven, Drivers driver, string bodyType, string colour, string upholstery, int numberOfDoors) : base(registrationNumber, make, model, kilometerDriven, driver)
		{
			this.bodyType = bodyType;
			this.colour = colour;
			this.upholstery = upholstery;
			this.numberOfDoors = numberOfDoors;
		}
		//method to change car's colour:
		public string ChangeColor(string newColour) {
			Console.WriteLine("\nChanging car's colour.....");
			Console.WriteLine("Old colour: " + this.colour);
			this.colour = newColour;
			Console.WriteLine("New paint color: "+this.colour+"\n");
			return this.colour; }

		//method to display car details:
		public void DisplayCarDetails() { Console.WriteLine("\nCar details: \n"); Console.WriteLine("Body type is " + this.bodyType + ". colour is " + this.colour + ". upholstery is " + this.upholstery + ". number of doors is " + this.numberOfDoors); }
		//method to display generic and specific car details with driver details:
		public override void DisplayAll() { Console.WriteLine("\nCar - Show all: \n"); DisplayCarDetails(); base.DisplayAll();  }
	}
}
