using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral.Visitor.Sample
{
    public interface IVisitor
    {
        void Visit(Element element);
    }
}
