//#define INHERITANCE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	internal class Program
	{
		static readonly string delimiter = "\n--------------------------------------------------------\n";
		static void Main(string[] args)
		{
#if INHERITANCE
			Human human = new Human("Montana", "Antonio", 25);
			human.Info();
			Console.WriteLine(delimiter);

			Student student = new Student("Pinkman", "Jessie", 22, "Chemistry", "WW-220", 95, 96);
			student.Info();
			Console.WriteLine(delimiter);

			Teacher teacher = new Teacher("White", "Walter", 50, "Chemistry", 25);
			teacher.Info();
			Console.WriteLine(delimiter);

			Human tommy = new Human("Varcetty", "Tommy", 30);
			tommy.Info();
			Console.WriteLine(delimiter);

			Student s_tommy = new Student(tommy, "Theft", "Vice", 95, 98);
			s_tommy.Info();
			Console.WriteLine(delimiter);

			Graduate graduate = new Graduate("Schreder", "Hank", 40, "Criminalistic", "OBN", 70, 80, "How to catch Heizenberg");
			graduate.Info();
			Console.WriteLine(delimiter); ///  Досмотреть видео c 51:37

			Graduate g_tommy = new Graduate(s_tommy, "How to make money");
			g_tommy.Info();
			Console.WriteLine(delimiter); 
#endif


			Human[] group = new Human[]
				{
				new Student("Pinkman", "Jessie", 22, "Chemistry", "WW-220", 95, 96),
				new Teacher("White", "Walter", 50, "Chemistry", 25),
				new Graduate("Varcetty", "Tommy", 30,"Theft", "Vice", 95, 98, "How to make money"),
				new Graduate("Schreder", "Hank", 40, "Criminalistic", "OBN", 70, 80, "How to catch Heizenberg"),
				new Teacher("Diaz", "Ricardo", 50, "Weapons distribution", 20),
				};
			for (int i=0;  i<group.Length; i++)
			{
				group[i].Info();
			}

		}

	}

}
	



		//Graduate graduate = new Graduate("Pinkman", "Jessie", 35, "Chemistry", "WW-220", "Organic chemistry");
		//graduate.Info();
		//Console.WriteLine(delimiter); //Добавленный дипломник

		//Specialist specialist = new Specialist("Lomax", "Kevin", 30, "Lawyer", 10);
		//specialist.Info();
		//Console.WriteLine(delimiter); //Добавленный специалист