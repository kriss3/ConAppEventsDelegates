using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppEventsDelegates
{
	class ksPerson
	{	
		//Event setup
		public delegate string ksPersonHandler(string message);
		public event ksPersonHandler ksEvent;

		// Class setup
		public string FName { get; set; }
		public string LName { get; set; }
		public float Age { get; set; }

		public ksPerson(string fn, string ln, float a)
		{
			FName = fn;
			LName = ln;
			Age = a;
		}

		public void PrintSth()
		{
			OnKsPerson("TEST 1\n");
			OnKsPerson("TEST 2\n");
			OnKsPerson("TEST 3\n");
		}

		protected virtual void OnKsPerson(string message)
		{
			if(ksEvent != null)
			{
				ksEvent(message);
			}
		}

	}
}
