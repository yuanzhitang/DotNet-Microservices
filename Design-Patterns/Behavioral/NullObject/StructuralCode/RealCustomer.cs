using Design_Patterns.Behavioral.Observer.Structuralcode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Design_Patterns.Behavioral.NullObject.StructuralCode
{
    public class RealCustomer : AbstractCustomer
    {

    public RealCustomer(String name)
    {
        this.name = name;
    }
    public override bool isNil()
    {
        return false;
    }

   
    public override String getName()
{
        return name;
    }

}
}
