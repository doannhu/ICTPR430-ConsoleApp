using System;
using System.Collections.Generic;
using System.Text;

namespace ICTPR430_ConsoleApp
{
	class Cars : Vehicles
	{
		private string _bodyType;
		private string _colour;
		private string _upholstery;
		private int _numberOfDoors;
		public Cars(string _registrationNumber, string _make, string _model, int _kilometerDriven, Drivers driver, string _bodyType, string _colour, string _upholstery, int _numberOfDoors) : base(_registrationNumber, _make, _model, _kilometerDriven, driver)
		{
			this._bodyType = _bodyType;
			this._colour = _colour;
			this._upholstery = _upholstery;
			this._numberOfDoors = _numberOfDoors;
		}
		public string ChangeColor(string newColour) { this._colour = newColour; return this._colour; }
		public void DisplayCarDetails() { Console.WriteLine("\nCar details\n"); Console.WriteLine("Body type is " + this._bodyType + ". colour is " + this._colour + ". upholstery is " + this._upholstery + ". number of doors is " + this._numberOfDoors); }
		public override void DisplayAll() { Console.WriteLine("\nCar - Show all: \n"); DisplayCarDetails(); base.DisplayAll();  }
	}
}
