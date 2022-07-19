using System;
using System.Collections.Generic;
using System.Text;

namespace ICTPR430_ConsoleApp
{
    class Vehicles
    {
		private string registrationNumber;
		private string make;
		private string model;
		private int kilometerDriven;
		Drivers driver;
		public Vehicles(string registrationNumber, string make, string model, int kilometerDriven, Drivers driver)
		{
			this.registrationNumber = registrationNumber;
			this.make = make;
			this.model = model;
			this.kilometerDriven = kilometerDriven;
			this.driver = driver;
		}
		//method to add kilometer drive
		public int UpdateKilometer(int addKilometer)
		{
			Console.WriteLine("\nUpdating kilometer driven.....");
			Console.WriteLine("Current odometer reading: " +this.kilometerDriven);
			Console.WriteLine("Kilometer's being added: " + addKilometer);			
			this.kilometerDriven += addKilometer;
			if (this.kilometerDriven <= 0) { 
				Console.WriteLine("Invalid kilometer adjustment. Please re-enter");
				this.kilometerDriven -= addKilometer;
			} else
			{
				Console.WriteLine("New odometer reading: " + this.kilometerDriven + "\n");
			}
			return this.kilometerDriven;
		}
		//method to display vehicle details:
		public void DisplayVehicleDetails()
		{
			Console.WriteLine("\nVehicle details: ");   
			Console.WriteLine("Rego is " + this.registrationNumber + ". make is " + this.make + ". model is " + this.model + ". km's are " + this.kilometerDriven + ".\n");
		}
		//method to display vehicle and driver details:
		public virtual void DisplayAll()
		{
			this.DisplayVehicleDetails();
			this.driver.DisplayDriver();
			
		}
	}
}
