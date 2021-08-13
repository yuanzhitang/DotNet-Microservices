using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Structural.Decorator.Sample
{
	class FouthGradeSchoolReport : SchoolReport
	{
		public override void Report()
		{
			Console.WriteLine("Chinese：62， Mathematics： 65， English：63");
		}

		public override void Sign(string name)
		{
			Console.WriteLine($"Signature: {name}");
		}
	}
}
