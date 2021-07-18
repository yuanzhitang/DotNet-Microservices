using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral.Visitor.Sample
{
    public abstract class Element
    {
        public abstract void Accept(IVisitor visitor);
    }
}
