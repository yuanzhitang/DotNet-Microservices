using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Structural.Decorator.Sample
{
	public abstract class SchoolReport
	{
		public abstract void Report();

		public abstract void Sign(string name);
	}
}
