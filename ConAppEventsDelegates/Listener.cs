using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppEventsDelegates
{
	class Listener
	{
		public void Subscribe(Metronome m)
		{
			m.Tick += new Metronome.TickHandler(HandleIt);
		}

		private void HandleIt(Metronome m)
		{
			Console.WriteLine("Heard IT !!!");
		}

	}
}
