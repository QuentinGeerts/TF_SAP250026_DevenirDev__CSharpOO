using DemoExceptions.Exceptions;

namespace DemoExceptions.Models;

internal static class Conversion
{
    public static bool TryParse(string value, out int convertedValue)
    {
        if (value == null) throw new ArgumentNullException();
        if (value == "Quentin") throw new QuentinException("La valeur entrée est 'Quentin'", "value");

		try
		{
            convertedValue = int.Parse(value);
            return true;
        }
        catch (Exception e)
		{
            switch (e)
            {
                case ArgumentNullException:
                    Console.WriteLine($"La valeur à convertir ne peut pas être nulle.");
                    break;
                case FormatException:
                    Console.WriteLine($"La valeur n'est pas dans un format convertissable.");
                    break;
                case OverflowException:
                    Console.WriteLine($"La valeur à convertir est trop grande ou trop petite.");
                    break;
            }
            convertedValue = 0;
            return false;
		}
        finally
        {
            Console.WriteLine($"Conversion terminée.");
        }
    }
}
