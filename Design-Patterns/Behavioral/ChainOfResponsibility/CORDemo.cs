using Design_Patterns.Behavioral.ChainOfResponsibility.Sample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral.ChainOfResponsibility
{
	public class CORDemo : PatternDemoBase
	{
		public override string PatternName => "Chain of Responsibilty ";

		protected override void RunImpl()
		{
			VacationCOR requestChainOfResponsibility = new VacationCOR();
			int[] requests = {1,2, 5, 14, 22, 18, 3, 27, 20 };
			foreach (int request in requests)
			{
				requestChainOfResponsibility.handleRequest(request);
			}
		}
	}
}
