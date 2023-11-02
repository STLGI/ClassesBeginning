namespace ClassLib
{
	public class Rectangle
	{
		private double _side1, _side2;
		public Rectangle(double side1, double side2)
		{
			_side1 = side1;
			_side1 = side2;
		}

		public double AreaCalculator()
		{
			return _side1 * _side2;
		}
		public double PerimeterCalculator()
		{ 
			return _side1 * 2 + _side2 * 2;
		}
		public double Area
		{
			get
			{
				return AreaCalculator();
			}
		}
		public double Perimeter
		{
			get
			{
				return PerimeterCalculator();
			}
		}
	}
}