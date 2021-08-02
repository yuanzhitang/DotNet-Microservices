namespace Design_Patterns.Structural.ProxyPattern.Structural_code
{
	public class Proxy : Subject
	{
		RealSubject RealSubject { get; set; } = null;
		public override void Request()
		{
			if (RealSubject == null)
			{
				RealSubject = new RealSubject();
			}

			RealSubject.Request();
		}
	}
}
