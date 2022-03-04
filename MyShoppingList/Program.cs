using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MyShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\....\Samples\";
            Console.WriteLine("Palun sisesta kasuta nimi:");
            string newDirectory = Console.ReadLine();
            Console.WriteLine("Palun sisesta fiali nimi:");
            string fileName = Console.ReadLine();
       

            if (Directory.Exists($"{rootDirectory}\\{newDirectory}") && File.Exists($"{rootDirectory}\\{newDirectory}\\{fileName}"))
            {
                Console.WriteLine($"Directory and file exist.");

            }
            else
            {
                Directory.CreateDirectory($"{rootDirectory}\\{newDirectory}");
                File.Create($"{rootDirectory}\\{newDirectory}\\{fileName}").Close();
            }
         

            string[] arrayFromFile = File.ReadAllLines($"{rootDirectory}\\{newDirectory}\\{fileName}");
            List<string> myShoppingList = arrayFromFile.ToList<string>();

            bool loopActive = true;

            while (loopActive)
            {
                Console.WriteLine("Kas soovid midagi lisada? Y/N");
                char userInput = Convert.ToChar(Console.ReadLine().ToLower());

                if (userInput == 'y')
                {
                    Console.WriteLine("Lisage oma soov!");
                    string userWish = Console.ReadLine();
                    myShoppingList.Add(userWish);
                }
                else
                {
                    loopActive = false;
                    Console.WriteLine("Kena päeva!");
                }
            }

            Console.Clear();

            foreach (string wich in myShoppingList)
            {
                Console.WriteLine(wich);
            }

            File.WriteAllLines($"{rootDirectory}{fileName}", myShoppingList);

        }
    }
}
