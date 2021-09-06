using Design_Patterns.Behavioral.TemplateMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
    public class BookFactory
    {

        public Book getBook(int ID)
        {
            Book book;
            switch (ID)
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




