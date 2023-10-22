namespace ClassesBeginning
{
	using ClassLib;
	internal class Program
	{
		static void Main(string[] args)
		{
			//Выбор задания

			int assignNum;
			Console.WriteLine("Выберите задание: \n" + "1 - Rectangle \n" + "2 - Book\n" + "3 - Point");
			string? assignStr = Console.ReadLine();

			//проверка на int

			try
			{
				Convert.ToInt32(assignStr);
			}
			catch {
				Console.WriteLine("Введенное вами значение даже не является целочисленным числом!");
				Environment.Exit(1);
			}
			assignNum = Convert.ToInt32(assignStr);

			//Прямоугольник

			if (assignNum == 1)
			{

				//Присвоение значений

				Console.WriteLine("Введите значения сторон прямоугольника: ");
				double side1, side2;
				side1 = Convert.ToDouble(Console.ReadLine());
				side2 = Convert.ToDouble(Console.ReadLine());
				Rectangle rectangle = new Rectangle(side1, side2);

				//Вывод ответов

				Console.WriteLine("Периметр прямоугольника равен " + rectangle.Perimeter);
				Console.WriteLine("Площадь прямоугольника равна " + rectangle.Area);
			}
			
			//Книга

			else if(assignNum == 2)
			{
				Book book = new Book();

				//Название книги

				Console.WriteLine("Введите название книги: ");
				string? title = Console.ReadLine();
				if (title != null)
				{
					book.SetTitle = title;
				}

				//Автор книги

				Console.WriteLine("Введите автора книги: ");
				string? author = Console.ReadLine();
				if (author != null)
				{
					book.SetAuthor = author;
				}

				//Содержание книги

				Console.WriteLine("Введите содержание книги: ");
				string? content = Console.ReadLine();
				if (content != null)
				{
					book.SetContent = content;
				}

				//Вывод всего на экран

				book.bookTitle.Show();
				book.bookAuthor.Show();
				book.bookContent.Show();
			}

			else if(assignNum == 3)
			{
				//Введение значений точек
				Console.WriteLine("Введите количество точек(от 3 до 5): ");
				int num = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Введите коордниаты 1 точки: ");
				Point point1 = new Point(Convert.ToInt64(Console.ReadLine()), Convert.ToInt64(Console.ReadLine()), "1");
				Console.WriteLine("Введите коордниаты 2 точки: ");
				Point point2 = new Point(Convert.ToInt64(Console.ReadLine()), Convert.ToInt64(Console.ReadLine()), "2");
				Console.WriteLine("Введите коордниаты 3 точки: ");
				Point point3 = new Point(Convert.ToInt64(Console.ReadLine()), Convert.ToInt64(Console.ReadLine()), "3");

				//Если точек 3

				if (num == 3)
				{
					Figure polygon = new Figure (point1, point2, point3);
					Console.Write("Треугольник, периметр - ");
					polygon.PerimeterCalculator();
				}

				//Если точек 4

				if(num == 4) {
					Console.WriteLine("Введите коордниаты 4 точки: ");
					Point point4 = new Point(Convert.ToInt64(Console.ReadLine()), Convert.ToInt64(Console.ReadLine()), "4");
					Figure polygon = new Figure(point1, point2, point3, point4);
					Console.Write("Четырехугольник, ");
					polygon.PerimeterCalculator();
				}

				//Если точек 5

				if (num == 5)
				{
					Console.WriteLine("Введите коордниаты 4 точки: ");
					Point point4 = new Point(Convert.ToInt64(Console.ReadLine()), Convert.ToInt64(Console.ReadLine()), "4");
					Console.WriteLine("Введите коордниаты 5 точки: ");
					Point point5 = new Point(Convert.ToInt64(Console.ReadLine()), Convert.ToInt64(Console.ReadLine()), "5");
					Figure polygon = new Figure(point1, point2, point3, point4, point5);
					Console.Write("Пятиугольник, ");
					polygon.PerimeterCalculator();
				}

				

			}

			//Если введен не существующий номер

			else
			{
				Console.WriteLine("Введенного номера задания не существует!");
			}
		}
	}
}