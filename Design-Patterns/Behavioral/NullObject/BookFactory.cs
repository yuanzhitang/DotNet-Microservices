namespace Design_Patterns
{
	public class BookFactory
	{
		public Book QueryBook(int id)
		{
			Book book;
			switch (id)
			{
				case 1:
					book = new Book();
					break;
				case 2:
					book = new Book();
					break;
				default:
					// book = null;
					book = new NullBook();//创建一个NullBook对象
					break;
			}

			return book;
		}
	}
}




