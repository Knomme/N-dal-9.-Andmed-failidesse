using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MyWishlistFile
{
	class Program
	{
		static void Main(string[] args)
		{

			string fileLocatsion = @"C:\Users\....\Samples\WishList";
			string fileName = @"\\myWishList.txt";

			string[] arrayFromFile = File.ReadAllLines($"{fileLocatsion}{fileName}");
			List<string> myWishList = arrayFromFile.ToList<string>();

			bool loopActive = true;

			while (loopActive)
			{
				Console.WriteLine("Would you add a wish? Y/N");
				char userInput = Convert.ToChar(Console.ReadLine().ToLower());

				if (userInput == 'y')
				{
					Console.WriteLine("Eneter your wish");
					string userWish = Console.ReadLine();
					myWishList.Add(userWish);
				}
				else
				{
					loopActive = false;
					Console.WriteLine("Take care!");
				}

			}

			Console.Clear();

			foreach (string wich in myWishList)
			{
				Console.WriteLine(wich);
			}

			File.WriteAllLines($"{fileLocatsion}{fileName}", myWishList);

		}
	}
}
