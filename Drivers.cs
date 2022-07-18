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
		public int UpdatePoint(int demeritPoint)
		{
			if (demeritPoint >= maxDemerit)
			{
				Console.WriteLine("You loose your licence!");
				this.point = 0;
			}
			else if (demeritPoint >= 9)
			{
				Console.WriteLine("License suspension is imminent!");
				this.point = this.point - demeritPoint;
			}
			else this.point = this.point - demeritPoint;
			return this.point;
		}
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

