using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
	public class Book
	{
		public Title bookTitle = new Title();
		public Author bookAuthor = new Author();
		public Content bookContent = new Content();
		public Book()
		{

		}
		public string SetTitle { 
			set {
				bookTitle.title = value;
			} 
		}
		public string SetAuthor
		{
			set
			{
				bookAuthor.author = value;
			}
		}
		public string SetContent
		{
			set
			{
				bookContent.content = value;
			}
		}
	}

	public class Title
	{
		public string? title;
		public void Show() {
			if (title != null)
			{
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine(title);
				Console.ResetColor();
			}
		}

	}
	public class Author
	{
		public string? author;
		public void Show()
		{
			if(author != null)
			{
				Console.ForegroundColor= ConsoleColor.Red;
				Console.WriteLine(author);
				Console.ResetColor();
			}
		}
	}
	public class Content
	{
		public string? content;
		public void Show()
		{
			if(content != null)
			{
				Console.ForegroundColor = ConsoleColor.Blue;
				Console.WriteLine(content);
				Console.ResetColor();
			}
		}
	}
}
