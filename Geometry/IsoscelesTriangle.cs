using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geometry
{
	class IsoscelesTriangle : Triangle
	{
		public IsoscelesTriangle(int baseLength, int height, int start_x, int start_y, int line_width, Color color)
			: base(baseLength, height, start_x, start_y, line_width, color) { }

		public override double GetArea() => 0.5 * Base * Height;

		public override double GetPerimeter()
		{
			double side = Math.Sqrt((Base / 2.0) * (Base / 2.0) + Height * Height);
			return Base + 2 * side;
		}

		public override void Draw(PaintEventArgs e)
		{
			Point[] points = new Point[3];
			points[0] = new Point(StartX, StartY + Height);
			points[1] = new Point(StartX + Base, StartY + Height);
			points[2] = new Point(StartX + Base / 2, StartY);

			e.Graphics.DrawPolygon(new Pen(Color, LineWidth), points);
		}
	}
}
