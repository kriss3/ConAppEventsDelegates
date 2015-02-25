using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Configuration;

namespace ConAppEventsDelegates
{
	class Helper
	{
		public static bool openFile(string path)
		{
			bool result = false;
			try
			{
				List<string> myStringList = new List<string>();
				using (StreamReader sr = new StreamReader(path))
				{
					string line = String.Empty;
					while ((line = sr.ReadLine()) != null)
					{
						myStringList.Add(line);
					}
					sr.Close();
					result = true;
				}
			}
			catch (Exception ex)
			{
				String.Format(ex.Message);
			}
			return result;
		}

		public static void Delegates()
		{
			DelegatesEvents de = new DelegatesEvents();
			de.myTest();
		}

		public static void RunFive()
		{
			DelEves myDel = new DelEves(5);
			myDel.SetValue(10);
			myDel.SetValue(15);
		}

		//This is my MainMethod dor BoilerLog - and subscriber to Boiler Event
		public static void RunSix()
		{
			BoilerInfoLogger fileLog = new BoilerInfoLogger(ConfigurationManager.AppSettings["boilerLogger"]);
			DelegateBoilerEvent boilerEvent = new DelegateBoilerEvent();

			//subscribsion
			boilerEvent.BoilerEventLog += new DelegateBoilerEvent.BoilerLogHandler(Logger);
			boilerEvent.BoilerEventLog += new DelegateBoilerEvent.BoilerLogHandler(fileLog.Logger);
			boilerEvent.LogProcess();

			fileLog.Close();
		}

		private static void Logger(string info)
		{
			Console.WriteLine(info);
		}

		static int counter = 0;
		private static string Info(string memo)
		{
			counter += 1;
			string val = Convert.ToString(counter);
			string result = String.Format("Memo and counter {0}", counter);
			Console.WriteLine(result);
			return result;
		}

		public static void RunSeven()
		{
			ksPerson p1 = new ksPerson("Piotr", "But", 23);
			p1.ksEvent += new ksPerson.ksPersonHandler(Info);
			p1.PrintSth();
		}

		public static void RunEight()
		{
			Metronome met = new Metronome();
			Listener lnr = new Listener();
			lnr.Subscribe(met);
			met.Start();
		}
	}
}
