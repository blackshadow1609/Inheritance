using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	internal class Specialist:Human
	{
		public string Speciality { get; set; }
		public double Experience { get; set; }
		public Specialist
			(
			string lastName, string firstName, int age,
			string speciality, double experience
			) : base(lastName, firstName, age)
		{
			Speciality = speciality;
			Experience = experience;
			Console.WriteLine($"TConstructor:\t {this.GetHashCode()}");
		}

		~Specialist()
		{
			Console.WriteLine($"TDestructor:\t {this.GetHashCode()}");
		}

		public void Info()
		{
			base.Info();
			Console.WriteLine($"{Speciality} {Experience}");
		}
	}
}

