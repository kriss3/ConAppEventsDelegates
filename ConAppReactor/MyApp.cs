using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppReactor
{
	class MyApp
	{
		static void Main(string[] args)
		{
			Reactor myReactor = new Reactor();

			ReactorMonitor rm = new ReactorMonitor(myReactor);

			Console.WriteLine("Setting temp to 100 degree");
			myReactor.Temperature = 100;

			Console.WriteLine("Setting temp to 500 degree");
			myReactor.Temperature = 500;

			Console.WriteLine("Setting temp to 1500 degree");
			myReactor.Temperature = 1500;

			Console.ReadLine();
		}
	}
}
