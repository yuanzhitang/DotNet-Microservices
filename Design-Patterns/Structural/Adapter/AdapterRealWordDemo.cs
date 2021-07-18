using Design_Patterns.Structural.Adapter.Sample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Structural.Adapter
{
    public class AdapterRealWordDemo : PatternDemoBase
    {
        public override string PatternName => "Adapter";

        protected override void RunImpl()
        {
            Compound unknown = new Compound();
            unknown.Display();
            // Adapted chemical compounds
            Compound water = new RichCompound("Water");
            water.Display();
            Compound benzene = new RichCompound("Benzene");
            benzene.Display();
            Compound ethanol = new RichCompound("Ethanol");
            ethanol.Display();
        }
    }
}
