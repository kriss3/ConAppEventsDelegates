using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppEventsDelegates
{
	class Boiler
	{
		public int Temp { get; set; }
		public int Pressure { get; set; }

		public Boiler(int t, int p)
		{
			Temp = t;
			Pressure = p;
		}
	}
}
