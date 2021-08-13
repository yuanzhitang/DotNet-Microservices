using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational.Prototype.Structuralcode
{
	public abstract class AbstractPrototype
	{
		string property;
		public AbstractPrototype(string property)
		{
			this.property = property;
		}

		public string Property
		{
			get { return property; }
		}

		public abstract AbstractPrototype Clone();

	}
}
