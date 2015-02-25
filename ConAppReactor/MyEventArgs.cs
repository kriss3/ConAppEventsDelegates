using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppReactor
{
	class MyEventArgs: EventArgs
	{
		private string _message;
		public String Message
		{
			get { return _message; }
		}

		public MyEventArgs(string msg)
		{
			_message = msg;
		}
	}
}
