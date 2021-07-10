using Design_Patterns.Behavioral.Observer;
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

			Console.ReadLine();
		}
	}
}
