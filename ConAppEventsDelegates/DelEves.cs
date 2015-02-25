using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppEventsDelegates
{
	class DelEves
	{
		// EVENT SETUP
		public delegate void NumManipulationHandler();
		public event NumManipulationHandler ChangeNumber;

		protected virtual void OnNumberChanged()
		{
			if (ChangeNumber != null)
			{
				ChangeNumber();
			}
			else
			{
				Console.WriteLine("Event Fired !!!");
			}
		}

		//CLASS SETUP
		public int myValue { get; set; }
		
		public DelEves(int num)
		{
			SetValue(num);
		}

		public void SetValue(int num)
		{
			if (myValue != num)
			{
				myValue = num;
				OnNumberChanged();
			}
		}

	}
}
