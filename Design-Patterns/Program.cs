using Design_Patterns.Behavioral.Observer;
using Design_Patterns.Behavioral.TemplateMethod;
using Design_Patterns.Structural.Decorator;
using System;

namespace Design_Patterns
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello Design-Patterns!");

			var observerDemo = new ObserverDemo();
			observerDemo.Run();

			var templatedMethodDemo = new TemplateMethodDemo();
			templatedMethodDemo.Run();

			var decoratorDemo = new DecoratorDemo();
			decoratorDemo.Run();

			Console.ReadLine();
		}
	}
}
