using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral.Observer.Structuralcode
{
    public abstract class AbstractCustomer
    {

        protected String name;

        public abstract bool isNil();

        public abstract String getName();

    }
}
