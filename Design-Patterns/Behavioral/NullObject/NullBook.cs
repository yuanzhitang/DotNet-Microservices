using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral.TemplateMethod
{
    public class NullBook : Book
    {
        public bool isNull()
        {
            return true;
        }

        public void show()
        {
            Console.WriteLine("Sorry，未找到符合您输入的ID的图书信息，请确认您输入的不是非法值。");
        }
    }
}

