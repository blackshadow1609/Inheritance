using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geometry
{
	internal class EquilateralTriangle : Triangle
	{
		double side;
		public double Side
		{
			get => side;
			set => side = value < MIN_SIZE ? MIN_SIZE : value > MAX_SIZE ? MAX_SIZE : value;
		}
		public EquilateralTriangle(double side,int start_x, int start_y, int line_width, System.Drawing.Color color)
			: base(start_x, start_y, line_width, color)
		{
			this.Side = side;
		}
		public override double GetHeight()
		{
			return Math.Sqrt(Math.Pow(Side, 2) - Math.Pow(Side / 2, 2));
		}
		public override double GetArea()
		{
			return Side * GetHeight() / 2;
		}
		public override double GetPerimeter()
		{
			return;
		}
	}
}
