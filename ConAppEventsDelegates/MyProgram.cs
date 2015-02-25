using System;
using System.Collections.Generic;
using System.Text;

using System.Xml;
using System.Linq;
using System.Xml.Linq;
using System.Configuration;

namespace ConAppEventsDelegates
{
	class MyProgram
	{
		static void Main(string[] args)
		{
			//File Setup:
			string filePath = ConfigurationManager.AppSettings["xmlBooks"];
			string filePath1 = ConfigurationManager.AppSettings["letters"];
			string answer = "y";

			while (answer.ToLower() == "y")
			{
				//Pick a 
				Console.Write("Pick a number:\t");
				int result = Convert.ToInt32(Console.ReadLine());

				switch (result)
				{
					case 1:
						RunOne(filePath);
						break;
					case 2:
						RunTwo(filePath);
						break;
					case 3:
						RunThree(filePath1);
						break;
					case 4:
						RunFour();
						break;
					case 5:
						RunFive();
						break;
					case 6:
						RunSix();
						break;
					case 7:
						RunSeven();
						break;
					case 8:
						RunEight();
						break;
					default:
						Console.WriteLine("This is not a valid number...");
						Console.ReadKey();
						break;
				}

				Console.Write("Again? [y/n]\t");
				answer = Console.ReadLine();
				
			}
		}
		/// <summary>
		/// Using DOM XML technique
		/// </summary>
		/// <param name="filePath"></param>
		private static void RunOne(string filePath)
		{
			Console.WriteLine("====== Lets Begin ======\n");
			XmlTextReader docReader = new XmlTextReader(filePath);
			string content = String.Empty;

			while (docReader.Read())
			{
				docReader.MoveToContent();
				if (docReader.NodeType == XmlNodeType.Element)
				{
					content += "<" + docReader.Name + ">\n";
				}

				if (docReader.NodeType == XmlNodeType.Text)
				{
					content += docReader.Value +  "\n";
				}
			}
			 
			Console.WriteLine(content);
		}

		/// <summary>
		/// Using Linq to XML
		/// </summary>
		/// <param name="filePath"></param>
		private static void RunTwo(string filePath)
		{
			XElement myXmlDoc = XElement.Load(filePath);

			string placeHolder = String.Empty;
			IEnumerable<XElement> elements =
				from el in myXmlDoc.Elements()
				select el;

			foreach (XElement item in elements)
			{
				IEnumerable<XElement> k =
					from n in item.Elements()
					select n;

				foreach (var m in k)
				{
					Console.WriteLine(m.Value + "\n");
				}
				Console.WriteLine();
			}
		}

		private static void RunThree(string filePath)
		{
			Helper.openFile(filePath);
		}
		
		private static void RunFour()
		{
			Helper.Delegates();
		}

		private static void RunFive()
		{
			Helper.RunFive();
		}

		private static void RunSix()
		{
			Helper.RunSix();
		}

		private static void RunSeven()
		{
			Helper.RunSeven();
		}

		private static void RunEight()
		{
			Helper.RunEight();
		}
	}
}
