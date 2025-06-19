using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Geometry
{
	class Square:Shape
	{
		double side;
		public double Side
		{
			get
			{
				return side;
			}
			set
			{
				side = value;
			}
		}
		public Square(double side, Color color) : base(color)
		{
			Side = side;
		}
		public override double GetArea()
		{
			return Side * Side;
		}
		public override double GetPerimeter()
		{
			return Side * 4;
		}
		public override void Draw()
		{
			for (int i = 0; i < Side; i++)
			{
				for(int j = 0; j < Side; j++)
				{
					Console.Write("* ");
				}
				Console.WriteLine();
			}
		}
		public override void Info()
		{
			Console.WriteLine($"Длина стороны: {Side}");
			base.Info();
		}
	}
}
