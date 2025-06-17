using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	internal class Graduate:Student
	{
		public string Subject { get; set; }
		public Graduate
			(
			string last_name, string first_name, int age,
			string speciality, string group, double rating, double attendance,
			string subject
			) : base(last_name, first_name, age, speciality, group, rating, attendance)
		{
			Subject = subject;
			Console.WriteLine($"GConstructor:\t {this.GetHashCode()}");
		}
		public Graduate(Student student, string subject):base(student)
		{
			Subject=subject;
			Console.WriteLine($"GConstructor:\t {this.GetHashCode()}");
		}

		~Graduate()
		{
			Console.WriteLine($"GDestructor:\t {this.GetHashCode()}");
		}
		public void Info()
		{
			base.Info();
			Console.WriteLine($"{Subject}");
		}

		/*public string Group { get; set; }
		public string Graduate_work { get; set; }
		public Graduate
			(
			string lastName, string firstName, int age,
			string speciality, string group, string graduate_work
			) : base(lastName, firstName, age)
		{
			Speciality = speciality;
			Group = group;
			Graduate_work = graduate_work;
			Console.WriteLine($"TConstructor:\t {this.GetHashCode()}");
		}

		~Graduate()
		{
			Console.WriteLine($"TDestructor:\t {this.GetHashCode()}");
		}

		public void Info()
		{
			base.Info();
			Console.WriteLine($"{Speciality} {Group} {Graduate_work}");
		}*/
	}
}
