using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppReactor
{
	//this class will subscribe to be notified when reactor overheats 
	class ReactorMonitor
	{
		public ReactorMonitor(Reactor myReactor)
		{
			if (myReactor != null)
				myReactor.OnMelting += new Reactor.MyHandler(DisplayMessage);
		}

		public void DisplayMessage(object reactor, MyEventArgs e)
		{
			Console.WriteLine(e.Message);
		}
	}
}
