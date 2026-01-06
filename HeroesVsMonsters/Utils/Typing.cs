
namespace HeroesVsMonsters.Utils;

public static class Typing
{
    public static void Write(string text, bool lineReturn = true, int delay = 5, int delayOut = 200)
    {
        foreach (var letter in text)
        {
            Thread.Sleep(delay);
            Console.Write(letter);
        }
        if (lineReturn) Console.WriteLine();
        Thread.Sleep(delayOut);
    }

    internal static void WaitForEnter(string text = $"\n\nAppuyer sur une touche...")
    {
        Console.WriteLine(text);
        Console.ReadKey();
        Console.Clear();
    }
}
