using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral.TemplateMethod
{
	public abstract class Manager
	{
		public static void main(String[] args)
		{
			BookFactory bookFactory = new BookFactory();
			Book book = bookFactory.getBook(-1);
			book.show();
		}

	}
}
