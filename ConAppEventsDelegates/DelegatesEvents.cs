using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppEventsDelegates
{
	public delegate string myDelHandler(string text);

	class DelegatesEvents
	{
		public event myDelHandler WorkPerformed;
		public event EventHandler WorkCompleted;


		public bool myTest()
		{

			myDelHandler test1 = new myDelHandler(test2);

			Console.WriteLine(test1("Hello from delegate call ..."));
		
			return true;
		}

		public string test2(string text)
		{
			return String.Format("This text: {0} is returned form method \"test2\" in class \"DelegatesEvents\"", text);
		}

		public void DoWork(int hours, WorkType workType)
		{
			myDelHandler del = WorkPerformed as myDelHandler;
			if (del != null)
			{
				del("Raised from DoWork, via casted delegate");
			}

			if (WorkPerformed != null)
			{
				WorkPerformed("test raised from DoWork(int housr WorkType workType) method");
			}
		}

		public enum WorkType
		{
			Golf,
			WritingReports,
			Break,
			Scrum
		}
	}
}
