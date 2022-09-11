using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace App1Taskkill
{


	class Program
	{
		static void Main(string[] args)
		{
			TransformToElephant();
			Console.WriteLine("Муха");
			//... custom application code
			// по условию здесь должно быть продолжение кода программы, поэтому я решил, что данную задачу можно решить вот так
			var standardOutput = new StreamWriter(Console.OpenStandardOutput());
			standardOutput.AutoFlush = true;
			Console.SetOut(standardOutput);
			Console.OutputEncoding = Encoding.GetEncoding("utf-8");
			Console.WriteLine("Змея");
			Console.WriteLine("НЕ слон");
		}

		static void TransformToElephant()
		{
			Console.WriteLine("Слон");
			StreamWriter writer = new StreamWriter("test.txt");
			Console.SetOut(writer);
		}

	}
}

