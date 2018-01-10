using CardGame;
using FileLister;
using System;

namespace CoreApp
{

	class Program
    {
		static void CardShuffelTest()
		{
			Deck deck = new Deck();

			var newDeck = deck.GenerateDeck();

			deck.PrintDeck(newDeck, "Before");


			ShuffleCards objSuffel = new ShuffleCards(newDeck);

			var suffeled = objSuffel.Shuffle();

			deck.PrintDeck(suffeled, "After");
		}

		static void GetFileListTest()
		{
			GetFileList objFileList = new GetFileList(@"c:\");
			objFileList.GetSummary();
			objFileList.GetDetails();
			Console.ReadLine();
		}

		static int GetUserInput()
		{
			int choice;
			bool flag = false;
			do
			{
				if (int.TryParse(Console.ReadLine(), out choice) == true)
				{
					return choice;
				}
				Console.WriteLine("Invalid input");
				
			} while (flag != true);
			return -1;
		}

		static void PresentOptions()
		{
			Console.WriteLine("Choose an option");
			Console.WriteLine("1. GetFileList");
			Console.WriteLine("2. CardShuffel");
			switch (GetUserInput())
			{
				case 1:

					GetFileListTest();
					break;

				case 2:

					CardShuffelTest();
					break;

				default:
					Console.WriteLine("Invalid Input");
					break;

			}
		}

        static void Main(string[] args)
        {

			while(true)
			PresentOptions();


		}
    }
}
