using System;
using System.Diagnostics;

namespace App1
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				FailProcess();
			}
			catch { }

			Console.WriteLine("Failed to fail process!");
			Console.ReadKey();
		}

		static void FailProcess()
		{
            //Environment.Exit(0); Второй вариант
            Process[] process = Process.GetProcesses();
            foreach (var proc in process)
            {
                if (proc.ProcessName == "App1")
                {
                    proc.Kill();
                }
            }
        }
	}
}
