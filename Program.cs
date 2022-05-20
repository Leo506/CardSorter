using TestTask;

public class Program
{
    public static void Main()
    {
        DeckManager manager = new DeckManager();

        manager.CreateNewDeck("First");

        foreach (var item in manager.GetDeck("First"))
            Console.WriteLine(item);

        Console.WriteLine("-------------------------------");

        manager.ShuffleDeck("First");

        foreach (var item in manager.GetDeck("First"))
            Console.WriteLine(item);
    }
}