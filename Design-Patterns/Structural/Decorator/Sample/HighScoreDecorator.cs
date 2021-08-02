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
			Console.WriteLine("各科最高分：语文：75， 数学：78， 英语：80");
		}
	}
}
