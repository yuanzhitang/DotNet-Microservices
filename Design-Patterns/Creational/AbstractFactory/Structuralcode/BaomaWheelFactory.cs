﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational.AbstractFactory.Structuralcode
{
	public class BaomaWheelFactory : IWheel
	{
		public Wheel CreateWheel()
		{
			return new BaomaWheel();
		}
	}
}
