// See https://aka.ms/new-console-template for more information
using PickRandomCards;


    Console.Write("Enter the number of cards to pick: ");
    string line = Console.ReadLine();
    if (int.TryParse(line, out int numberofCards))
    {
        foreach (string card in CardPicker.PickSomeCards(numberofCards))
        {
            Console.WriteLine(card);
        }
    }
    else
    {
        Console.WriteLine("Please Enter a Valid Number");
    }
