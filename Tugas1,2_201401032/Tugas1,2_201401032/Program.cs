using System;
namespace BelajarCSharp
{
	class programHW
	{
		static void Main(string[] args)
		{
			Console.Write("Nama kamu siapa? ");
			string nama = Console.ReadLine();
			Console.WriteLine("Nama kamu "+nama);
			Console.Write("Press any key to continue...");
			Console.Read();
		}
	}
}