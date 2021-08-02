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
			Console.WriteLine("各科最高分：语文：75， 数学：78， 英语：80");
		}

		private void ReportSort()
		{
			Console.WriteLine("我的名次: 35");
		}

		public override void Report()
		{
			ReportHighScore();
			Console.WriteLine("语文：62， 数学： 65， 英语：63");
			ReportSort();
		}

		public override void Sign(string name)
		{
			Console.WriteLine($"Signature: {name}");
		}
	}
}
