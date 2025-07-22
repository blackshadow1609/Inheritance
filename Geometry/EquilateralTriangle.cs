using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geometry
{
	class EquilateralTriangle : Triangle
	{
		public EquilateralTriangle(int side, int start_x, int start_y, int line_width, Color color)
			: base(side, (int)(side * Math.Sqrt(3) / 2), start_x, start_y, line_width, color) { }

		public override double GetArea() => (Math.Sqrt(3) / 4) * Base * Base;

		public override double GetPerimeter() => 3 * Base;

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
