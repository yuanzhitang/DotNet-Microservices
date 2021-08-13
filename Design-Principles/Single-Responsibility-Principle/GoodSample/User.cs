using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Principles.Single_Responsibility_Principle.GoodSample
{
	public class User
	{
		private string name;
		private string password;
		private Role role;
		private Org org;

		public User()
		{
			role = new Role();
			org = new Org();
		}

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public string Password
		{
			get { return password; }
			set { password = value; }
		}

		public void CreateUser()
		{
			name = "test";
			password = "testpassword";
			org.addOrg(this,1);
			role.addRole(this, 1);
		}

	}
}
