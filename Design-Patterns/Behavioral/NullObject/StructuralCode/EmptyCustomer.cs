using Design_Patterns.Behavioral.Observer.Structuralcode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Design_Patterns.Behavioral.NullObject.StructuralCode
{
    class EmptyCustomer : AbstractCustomer
    {
		public override bool isNil()
        {
            return true;

        }

        public override String getName()
        {
            return "this customer is empty";
        }
    }

}
