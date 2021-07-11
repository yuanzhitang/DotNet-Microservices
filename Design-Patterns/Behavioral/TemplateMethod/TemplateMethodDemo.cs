using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral.TemplateMethod
{
	public class TemplateMethodDemo : PatternDemoBase
	{
		public override string PatternName => "Template Pattern";

		protected override void RunImpl()
		{
			AbstractClass concreteClassA = new ConcreteClassA();
			concreteClassA.TemplateMethod();

			AbstractClass concreteClassB = new ConcreteClassA();
			concreteClassB.TemplateMethod();


			Sample.HummerH1Model h1 = new Sample.HummerH1Model();
			h1.SetAlarm(false);
			h1.Run();

			Sample.HummerH2Model h2 = new Sample.HummerH2Model();
			h2.Run();
		}
	}
}
