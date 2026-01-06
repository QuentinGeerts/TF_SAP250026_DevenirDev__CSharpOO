namespace DemoEvents.Models;

public class Displayer
{
    public void DisplayCounter(int counter, int threshold)
    {
        Console.WriteLine($"Le compteur '{counter}' a atteint le seuil de '{threshold}'");
    }
}
