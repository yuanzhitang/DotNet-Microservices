using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral.Observer
{

	public class ObserverDemo: PatternDemoBase
	{
		/*
		 * The Observer design pattern defines a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically.
		 */
		public override string PatternName => "Observer Pattern";

		protected override void RunImpl()
		{
			// Configure Observer pattern
			ConcreteSubject subject = new ConcreteSubject();

			subject.Attach(new ConcreteObserver(subject, "X"));
			subject.Attach(new ConcreteObserver(subject, "Y"));
			subject.Attach(new ConcreteObserver(subject, "Z"));

			// Change subject and notify observers
			subject.SubjectState = "ABC";
			subject.Notify();


			NewsPublisher publisher = new BusinessNewsPublisher();
			publisher.Attach(new SMSSubscriber());
			publisher.Attach(new EmailSubscriber());

			publisher.AddNews($"News1 {DateTime.Now.ToString()}");

			publisher.Notify();
		}
	}
}
