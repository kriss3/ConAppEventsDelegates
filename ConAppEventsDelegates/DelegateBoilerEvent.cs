using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppEventsDelegates
{
	//Event Publisher
	class DelegateBoilerEvent
	{
		public delegate void BoilerLogHandler(string status);
		public event BoilerLogHandler BoilerEventLog;

		public void LogProcess()
		{
			string remarks = "O.K.";
			Boiler b = new Boiler(20, 50);
			int t = b.Temp;
			int p = b.Pressure;


			if(t > 150 || t < 80 || p < 12 || p > 15)
			{
				remarks = "Need Maintenance";
			}

			OnBoilerEventLog("Logging Info:\n");
			OnBoilerEventLog("Temparature " + t + "\nPressure: " + p);
			OnBoilerEventLog("\nMessage" + remarks);
		}

		//Event Method
		protected virtual void OnBoilerEventLog(string message)
		{
			if (BoilerEventLog != null)
			{
				BoilerEventLog(message);
			}
			else
			{
				String.Format("Event Fired with info: {0}", message);
			}
		}
	}
}
