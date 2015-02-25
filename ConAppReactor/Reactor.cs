using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppReactor
{
	
	class Reactor
	{

		public delegate void MyHandler(object reactor, MyEventArgs myEA);

		public event MyHandler OnMelting;

		private int _temp;
		public int Temperature
		{
			set
			{
				_temp = value;
				if (_temp > 1000)
				{
					//Fire event: Create an instance of custom EventArgs and fire OnMeltdown
					MyEventArgs myEA = new MyEventArgs("Reactor is overheating and may meltdown !!!");
					OnMelting(this, myEA);
				}
			}
		}
	}
}
