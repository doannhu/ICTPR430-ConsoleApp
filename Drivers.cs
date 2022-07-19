using System;
using System.Collections.Generic;
using System.Text;

namespace ICTPR430_ConsoleApp
{
    class Drivers
    {
		public string licenceNo;
		public string[] stateLicensing;
		public string firstName;
		public string lastName;
		public string phoneNo;
		public string[] address;
		public int demeritPoint;
		static int maxDemerit = 12;
		static int minDemerit = 0;
		public Drivers(string licenceNo, string[] stateLicensing, string firstName, string lastName, string phoneNo, string[] address, int demeritPoint)
		{
			this.licenceNo = licenceNo;
			this.stateLicensing = stateLicensing;
			this.firstName = firstName;
			this.lastName = lastName;
			this.phoneNo = phoneNo;
			this.address = address;
			this.demeritPoint = demeritPoint;
		}
		//method to update driver's point:
		public int UpdatePoint(int addDemeritPoint)
		{
			Console.WriteLine("\nUpdating driver licence demerit point.....");
			Console.WriteLine("Current demerit point: "+ this.demeritPoint);
			Console.WriteLine("Add: " + addDemeritPoint);
			Console.WriteLine("then...");
			this.demeritPoint += addDemeritPoint;
			if (this.demeritPoint > maxDemerit)
            {
				this.demeritPoint = maxDemerit;
				Console.WriteLine("New demerit point: 12. Warning: licence suspension!\n");
            } else if (this.demeritPoint >=9)
            {
				Console.WriteLine("New demerit point: " + this.demeritPoint);
				Console.WriteLine("Warning: License suspension is imminent! \n");
            }
			else if (this.demeritPoint < minDemerit)
            {
				Console.WriteLine("Invalid added demerit point. Please re-enter!\n");
				this.demeritPoint -= addDemeritPoint;
            }
			else
            {
				Console.WriteLine("New demerit point: " + this.demeritPoint+ "\n");
			}
			return this.demeritPoint;
		}
		//method to display driver's address and state licensing:
		public void DisplayDriver()
		{
			Console.WriteLine("\nDriver details: " + " driver licence number: " + this.licenceNo + " " + ". driver name:  " + this.firstName + " " + this.lastName + ". phone:  " + this.phoneNo + ". demerit point: " + this.demeritPoint);
			Console.WriteLine("\nAddress is\n");
			for (int i = 0; i < this.address.Length; i += 2)
			{
				Console.WriteLine(this.address[i] + ":" + this.address[i + 1]);
			}

			string myString = "\nThe driver is licenced to drive in following states:\n";
			foreach (string sL in this.stateLicensing)
			{
				myString += sL;
				myString += " : ";
			}

			Console.WriteLine(myString);
		}

	}
}

