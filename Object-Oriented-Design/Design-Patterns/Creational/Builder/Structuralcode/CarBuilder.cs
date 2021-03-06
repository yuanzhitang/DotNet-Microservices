using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Creational.Builder.Structuralcode
{
	public class CarBuilder : IBuilder
	{
		private Product product = new Product();
		

		public void SetEngine()
		{
			product.Add("car");
		}

		public void SetGPS()
		{
			product.Add("car GPS");
		}

		public void SetSeats()
		{
			product.Add("5 SEATS");
		}

		public Product GetResult()
		{
			return product;
		}
	}
}
