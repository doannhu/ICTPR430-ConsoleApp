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
		public int point;
		static int maxDemerit = 12;
		public Drivers(string licenceNo, string[] stateLicensing, string firstName, string lastName, string phoneNo, string[] address, int point)
		{
			this.licenceNo = licenceNo;
			this.stateLicensing = stateLicensing;
			this.firstName = firstName;
			this.lastName = lastName;
			this.phoneNo = phoneNo;
			this.address = address;
			this.point = point;
		}
		//method to update driver's point:
		public int UpdatePoint(int demeritPoint)
		{
			Console.WriteLine("\nUpdating driver licence point.....");
			Console.WriteLine("Current point: "+ this.point);
			Console.WriteLine("Demerit point: " + demeritPoint);
			Console.WriteLine("then...");
			if (demeritPoint >= maxDemerit)
			{
				Console.WriteLine("You loose your licence!\n");
				this.point = 0;
			}
			else if (demeritPoint >= 9)
			{
				Console.WriteLine("License suspension is imminent!\n");
				this.point = this.point - demeritPoint;
			}
			else
			{
				this.point = this.point - demeritPoint;
				Console.WriteLine("New point: " + this.point+"\n");
			}
			return this.point;
		}
		//method to display driver's address and state licensing:
		public void DisplayAddressAndStates()
		{
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

