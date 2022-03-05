using System;
using System.Diagnostics;
using System.Threading;

namespace Test1
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				FailProcess();
			}
			catch {
				Console.WriteLine("поймана ошибка");
				Console.ReadKey();
			}

			Console.WriteLine("Failed to fail process!");
			Console.ReadKey();
		}

		static void FailProcess()
		{
			throw new Exception();
		}

		static void FailProcess2()
        {
            Process process = Process.GetCurrentProcess();
			process.Kill();
		}
	}
}

