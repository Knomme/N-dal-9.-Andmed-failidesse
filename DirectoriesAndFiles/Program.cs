using System;
using System.IO;

namespace DirectoriesAndFiles
{
	class Program
	{
		static void Main(string[] args)
		{
			string rootDirectroy = @"C:\Users\....\Samples";
			Console.WriteLine("Palun sisesta kasuta nimi:");
			string newDirectroy = Console.ReadLine();
			Console.WriteLine("Palun sisesta fiali nimi:");
			string fileName = Console.ReadLine();


			if (Directory.Exists($"{rootDirectroy}\\{newDirectroy}") && File.Exists($"{rootDirectroy}\\{newDirectroy}\\{fileName}"))
			{
				Console.WriteLine($"Directory and File exist.");
			}
			else
			{
				Directory.CreateDirectory($"{rootDirectroy}\\{newDirectroy}");
				File.Create($"{rootDirectroy}\\{newDirectroy}\\{fileName}");
			}
		}
	}
}
