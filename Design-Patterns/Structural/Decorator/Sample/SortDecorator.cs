using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Structural.Decorator.Sample
{
	class SortDecorator:SchoolReportDecorator
	{
		public SortDecorator(SchoolReport report):base(report)
		{
	
		}

		public override void Report()
		{
			ReportSort();
			base.Report();
		}

		private void ReportSort()
		{
			Console.WriteLine("我的名次: 35");
		}
	}
}
