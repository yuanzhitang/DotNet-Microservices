using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Structural.Decorator.Sample
{
	class SugarFouthGradeSchoolReport : FouthGradeSchoolReport
	{
		private void ReportHighScore()
		{
			Console.WriteLine("Highest Score：Chinese：75， Mathematics：78， English：80");
		}

		private void ReportSort()
		{
			Console.WriteLine("My Ranking: 35");
		}

		public override void Report()
		{
			ReportHighScore();
			Console.WriteLine("Chinese：62， Mathematics： 65， English：63");
			ReportSort();
		}

		public override void Sign(string name)
		{
			Console.WriteLine($"Signature: {name}");
		}
	}
}
