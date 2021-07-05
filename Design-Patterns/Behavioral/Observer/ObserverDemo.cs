using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral.Observer
{
	public class ObserverDemo
	{
		public static void Run()
		{
			Console.WriteLine("Observer Pattern");

			// Configure Observer pattern
			ConcreteSubject subject = new ConcreteSubject();

			subject.Attach(new ConcreteObserver(subject, "X"));
			subject.Attach(new ConcreteObserver(subject, "Y"));
			subject.Attach(new ConcreteObserver(subject, "Z"));

			// Change subject and notify observers
			subject.SubjectState = "ABC";
			subject.Notify();
			// Wait for user
			Console.ReadKey();
		}
    }
}
