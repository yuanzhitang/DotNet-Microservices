﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Structural.Decorator.Sample
{
	class SchoolReportDecorator : SchoolReport
	{
		private SchoolReport _report;

		public SchoolReportDecorator(SchoolReport report)
		{
			_report = report;
		}

		public override void Report()
		{
			_report.Report();
		}

		public override void Sign(string name)
		{
			_report.Sign(name);
		}
	}
}