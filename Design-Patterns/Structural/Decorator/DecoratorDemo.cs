using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Structural.Decorator
{
	public class DecoratorDemo : PatternDemoBase
	{
		/*
		 * The Decorator design pattern attaches additional responsibilities to an object dynamically. This pattern provide a flexible alternative to subclassing for extending functionality.
		 */

		public override string PatternName => "Decorator Pattern";

		protected override void RunImpl()
		{
			ConcreteComponent component = new ConcreteComponent();

			ConcreteDecoratorA decoratorA = new ConcreteDecoratorA();
			ConcreteDecoratorB decoratorB = new ConcreteDecoratorB();

			decoratorA.SetComponent(component);
			decoratorB.SetComponent(decoratorA);

			decoratorB.Operation();
		}
	}
}
