using TestTask;

public class Program
{
    public static void Main()
    {
        DeckManager manager = new DeckManager();

        Console.WriteLine("Adding new deck called \"First\"");
        manager.CreateNewDeck("First");

        Console.WriteLine("All names:");
        foreach (var item in manager.GetAllNames())
            Console.WriteLine(item);

        Console.WriteLine("Show full deck called \"First\"");
        foreach (var item in manager.GetDeck("First"))
            Console.WriteLine(item);

        Console.WriteLine("-------------------------------");

        
        manager.ShuffleDeck("First");

        Console.WriteLine("Show shuffled deck:");
        foreach (var item in manager.GetDeck("First"))
            Console.WriteLine(item);

        Console.WriteLine("Removing deck called \"First\"");
        manager.RemoveDeck("First");

        Console.WriteLine("All names:");
        foreach (var item in manager.GetAllNames())
            Console.WriteLine(item);
    }
}