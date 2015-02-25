using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConAppEventsDelegates
{
	class BoilerInfoLogger
	{
		FileStream fs;
		StreamWriter sw;

		public BoilerInfoLogger(string fileName)
		{
			fs = new FileStream(fileName, FileMode.Append, FileAccess.Write);
			sw = new StreamWriter(fs);
		}

		public void Logger(string info)
		{
			sw.WriteLine(info);
		}

		public void Close()
		{
			sw.Close();
			fs.Close();
		}
	}
}
