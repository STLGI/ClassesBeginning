using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
	public class Point
	{
		private long  _x, _y;
		private string? _num;
		public long X { get { return _x; } }
		public long Y { get { return _y; } }
		public string? Polygon { get { return _num; } }

		public Point(long x, long y, string? num)
		{
			_x = x;
			_y = y;
			_num = num;
		}
	}

	public class Figure
	{
		private Point? _point1, _point2, _point3, _point4, _point5;
		private int _count; 
		private double _perim;

		public Figure(Point point1, Point point2, Point point3)
		{
			_point1 = point1;
			_point2 = point2;
			_point3 = point3;
			_count = 3;
		}

		public Figure(Point point1, Point point2, Point point3, Point point4)
		{
			_point1 = point1;
			_point2 = point2;
			_point3 = point3;
			_point1 = point4;
			_count = 4;
		}
		public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
		{
			_point1 = point1;
			_point1 = point2;
			_point1 = point3;
			_point1 = point4;
			_point1 = point5;
			_count = 5;
		}

		public double LengthSide(Point A, Point B)
		{
			return Math.Sqrt(Math.Pow(B.X - A.X, 2) / Math.Pow(B.Y - A.Y, 2));
		}

		public void PerimeterCalculator()
		{
			if(_count == 3) {
				_perim = LengthSide(_point1, _point2) + LengthSide(_point2, _point3) + LengthSide(_point3, _point1);
			}
			if(_count == 4)
			{
				_perim = LengthSide(_point1, _point2) + LengthSide(_point2, _point3) + LengthSide(_point3, _point4) + LengthSide(_point4, _point1);
			}
			if(_count == 5)
			{
				_perim = LengthSide(_point1, _point2) + LengthSide(_point2, _point3) + LengthSide(_point3, _point4) + LengthSide(_point4, _point5) + LengthSide(_point5, _point1);
			}
			Console.WriteLine(_perim);
		}


	}
}
