using Design_Patterns.Behavioral.Observer.Structuralcode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral.NullObject.StructuralCode
{
    public class program
    {

        public static String[] names = {"Rob", "Joe", "Julie"};

    public static AbstractCustomer getCustomer(String name)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i]==(name))
                {
                    return new RealCustomer(name);
                }
            }
            return new EmptyCustomer();
        }

    }
}
