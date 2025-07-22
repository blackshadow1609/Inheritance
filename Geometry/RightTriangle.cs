using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geometry
{
	class RightTriangle : Triangle
	{
		public RightTriangle(int baseLength, int height, int start_x, int start_y, int line_width, Color color)
			: base(baseLength, height, start_x, start_y, line_width, color) { }

		public override double GetArea() => 0.5 * Base * Height;

		public override double GetPerimeter() => Base + Height + Math.Sqrt(Base * Base + Height * Height);

		public override void Draw(PaintEventArgs e)
		{
			Point[] points = new Point[3];
			points[0] = new Point(StartX, StartY);
			points[1] = new Point(StartX, StartY + Height);
			points[2] = new Point(StartX + Base, StartY + Height);

			e.Graphics.DrawPolygon(new Pen(Color, LineWidth), points);
		}
	}

}
