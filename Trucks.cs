using System;
using System.Collections.Generic;
using System.Text;

namespace ICTPR430_ConsoleApp
{
	class Trucks : Vehicles
	{
		private int _loadCap;
		private int _axles;
		private int _wheels;
		public Trucks(string _registrationNumber, string _make, string _model, int _kilometerDriven, Drivers driver, int _loadCap, int _axles, int _wheels) : base(_registrationNumber, _make, _model, _kilometerDriven, driver)
		{
			this._axles = _axles;
			this._loadCap = _loadCap;
			this._wheels = _wheels;
		}
		public void DisplayTruckDetails() { Console.WriteLine("The max load capacity is " + this._loadCap + ". axles are " + this._axles + ". number of wheels is " + this._wheels); }
		public override void DisplayAll() {Console.WriteLine("Truck - Show all: \n"); DisplayTruckDetails(); base.DisplayAll();  }
	}
}
