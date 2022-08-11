using System;

namespace Factory
{
    public sealed class EmptyConnection : IConnection
    {
		public void Connect()
		{
			Console.WriteLine("YOU DON'T SPECIFY A PROVIDER");
		}

		public void Disconnect()
		{
			Console.WriteLine("YOU DON'T SPECIFY A PROVIDER");
		}
	}
}