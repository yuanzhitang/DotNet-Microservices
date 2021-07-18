using Design_Patterns.Behavioral.Visitor.Structuralcode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral.Visitor
{
    public class VisitorStructuralDemo : PatternDemoBase
    {
        public override string PatternName => "Visitor (Structured)";

        protected override void RunImpl()
        {
            ObjectStructure o = new ObjectStructure();
            o.Attach(new ConcreteElementA());
            o.Attach(new ConcreteElementB());

            ConcreteVisitor1 v1 = new ConcreteVisitor1();
            ConcreteVisitor2 v2 = new ConcreteVisitor2();

            o.Accept(v1);
            o.Accept(v2);

        }
    }
}
