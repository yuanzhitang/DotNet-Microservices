using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Structural.Decorator.Sample
{
	class HighScoreDecorator:SchoolReportDecorator
	{
		public HighScoreDecorator(SchoolReport report):base(report)
		{
	
		}

		public override void Report()
		{
			ReportHighScore();
			base.Report();
		}

		private void ReportHighScore()
		{
			Console.WriteLine("Highest Score：Chinese：75， Mathematics：78， English：80");
		}
	}
}
