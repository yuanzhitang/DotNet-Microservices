using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Principles.Single_Responsibility_Principle.GoodSample
{
	public class Org
	{
		public void addOrg(User user, int orgId)
		{
			Console.WriteLine(user.Name + "added in org " + orgId);
		}
	}
}
