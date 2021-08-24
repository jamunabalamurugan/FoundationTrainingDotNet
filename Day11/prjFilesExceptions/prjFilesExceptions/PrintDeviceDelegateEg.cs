using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjFilesExceptions
{
	public class PrintToDevice
	{
		//Creating the variables of Stream classes
		static FileStream FStream;
		static StreamWriter SWriter;

		

		//Defining a Delegate
		public delegate void PrintData(String s);
		//Method to print a string to the console
		public static void WriteConsole(string str)
		{
			Console.WriteLine("{0} Console", str);
		}
		//Method to print a string to a file
		public static void WriteFile(string s)
		{
			//Initializing stream objects
			FStream = new FileStream("e:\\at\\StoreData.txt", FileMode.Append, FileAccess.Write);
			SWriter = new StreamWriter(FStream);
			s = s + " File";
			//Writing a string to the file
			SWriter.WriteLine(s);
			
			//Removing the content from the buffer
			SWriter.Flush();
			SWriter.Close();
			FStream.Close();
			
		}
		//Method to send the string data to respective methods
		public static void DisplayData(PrintData PMethod)
		{
			PMethod("This should go to the");
		}
		public static void Main()
		{
			//Initializing the Delegate object
			PrintData Cn = new PrintData(WriteConsole);
			PrintData Fl = new PrintData(WriteFile);
			//Invoking the DisplayData method with the Delegate object as the argument			//Using Delegate

			Cn("Hello ….Print to Console");
			Fl("Learning files on 24th Aug 2021");
			DisplayData(Cn);
			DisplayData(Fl);
			Console.ReadLine();
		}

	}
}
