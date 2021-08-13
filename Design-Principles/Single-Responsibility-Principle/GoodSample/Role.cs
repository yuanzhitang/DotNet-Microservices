using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Principles.Single_Responsibility_Principle.GoodSample
{
	public class Role
	{
		public void addRole(User user, int roleId)
		{
			Console.WriteLine(user.Name + "added in org " + roleId);
		}
	}
}
