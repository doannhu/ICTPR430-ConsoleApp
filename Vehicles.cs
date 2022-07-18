using System;
using System.Collections.Generic;
using System.Text;

namespace ICTPR430_ConsoleApp
{
    class Vehicles
    {
		private string _registrationNumber;
		private string _make;
		private string _model;
		private int _kilometerDriven;
		Drivers driver;
		public Vehicles(string _registrationNumber, string _make, string _model, int _kilometerDriven, Drivers driver)
		{
			this._registrationNumber = _registrationNumber;
			this._make = _make;
			this._model = _model;
			this._kilometerDriven = _kilometerDriven;
			this.driver = driver;
		}
		public int UpdateKilometer(int addKilometer)
		{
			if (addKilometer <= 0)
			{
				Console.WriteLine("Error: Invalid number! ");
			}
			else
			{
				this._kilometerDriven += addKilometer;
			}
			return this._kilometerDriven;
		}
		public void DisplayVehicleDetails()
		{
			Console.WriteLine("\nVehicle details: \n");   
			Console.WriteLine("Rego is " + this._registrationNumber + ". make is " + this._make + ". model is " + this._model + ". km's are " + this._kilometerDriven + ".");
		}
		public virtual void DisplayAll()
		{
			this.DisplayVehicleDetails();
			Console.WriteLine("\nDriver details: " +" driver licence number: "+ this.driver.licenceNo + " " + ". driver name:  " + this.driver.firstName + " " + this.driver.lastName + ". phone:  " + this.driver.phoneNo + ". point: " + this.driver.point);
			this.driver.DisplayAddressAndStates();
			
		}
	}
}
