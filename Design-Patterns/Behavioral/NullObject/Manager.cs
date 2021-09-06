using System;

namespace Design_Patterns.Behavioral.TemplateMethod
{
	public abstract class Manager
	{
		public static void Process(String[] args)
		{
			BookFactory bookFactory = new BookFactory();
			Book book = bookFactory.QueryBook(-1);
			book.Show();
		}

	}
}
