using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppReactor
{
	delegate void MyHandler(string message);
	class Reactor
	{
		public event MyHandler myEvent;

		private int _temp;
		public int Temperature
		{
			get { return _temp; }
			set
			{
				_temp = value;
				if (_temp > 200)
				{
					FireEvent();
				}
			}
		}

		private void FireEvent()
		{
			if (myEvent != null)
			{
				Console.WriteLine("Reactor is melting with !!!");
			}
		}
	}
}
