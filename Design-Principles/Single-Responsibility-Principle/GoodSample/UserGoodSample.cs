using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Principles.Single_Responsibility_Principle.GoodSample
{
	public static class UserGoodSample
	{
		public static void Run()
		{
			Console.WriteLine("------Good SRP Sample------");
			User user = new User();
			user.CreateUser();
		}
	}
}
