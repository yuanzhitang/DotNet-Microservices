using Design_Patterns.Structural.Adapter.Structuralcode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Structural.Adapter
{
    public class AdapterStructuralDemo : PatternDemoBase
    {
        public override string PatternName => "Adapter (Structured)";

        protected override void RunImpl()
        {
            Target target = new Structuralcode.Adapter();
            target.Request();

        }
    }
}
