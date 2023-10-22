using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
	public class Point
	{
		private long  x, y;
		private string? num;
		public long X { get { return x; } }
		public long Y { get { return y; } }
		public string? Polygon { get { return num; } }

		public Point(long x, long y, string? num)
		{
			this.x = x;
			this.y = y;
			this.num = num;
		}
	}

	public class Figure
	{
		private Point? point1, point2, point3, point4, point5;
		private int count; 
		private double perim;

		public Figure(Point point1, Point point2, Point point3)
		{
			this.point1 = point1;
			this.point2 = point2;
			this.point3 = point3;
			count = 3;
		}

		public Figure(Point point1, Point point2, Point point3, Point point4)
		{
			this.point1 = point1;
			this.point2 = point2;
			this.point3 = point3;
			this.point4 = point4;
			count = 4;
		}
		public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
		{
			this.point1 = point1;
			this.point2 = point2;
			this.point3 = point3;
			this.point4 = point4;
			this.point5 = point5;
			count = 5;
		}

		public double LengthSide(Point A, Point B)
		{
			return Math.Sqrt(Math.Pow(B.X - A.X, 2) / Math.Pow(B.Y - A.Y, 2));
		}

		public void PerimeterCalculator()
		{
			if(count == 3) {
				perim = LengthSide(point1, point2) + LengthSide(point2, point3) + LengthSide(point3, point1);
			}
			if(count == 4)
			{
				perim = LengthSide(point1, point2) + LengthSide(point2, point3) + LengthSide(point3, point4) + LengthSide(point4, point1);
			}
			if(count == 5)
			{
				perim = LengthSide(point1, point2) + LengthSide(point2, point3) + LengthSide(point3, point4) + LengthSide(point4, point5) + LengthSide(point5, point1);
			}
			Console.WriteLine(perim);
		}


	}
}
