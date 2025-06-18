﻿using System;
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
		public override void Info()
		{
			base.Info();
			Console.WriteLine($"{Subject}");
		}
		public override string ToString()
		{
			return base.ToString() + Subject;
		}
		public override string ToFileString()
		{
			return base.ToFileString() + $",{Subject}";
		}
		public override Human Init(string[] values)
		{
			base.Init(values);
			this.Subject = values[7];
			return this;
		}
	}
}
