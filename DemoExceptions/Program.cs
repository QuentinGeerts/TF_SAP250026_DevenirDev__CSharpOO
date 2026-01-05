using DemoExceptions.Models;

int convertedValue;

while (!Conversion.TryParse(Console.ReadLine(), out convertedValue))
{
    Console.WriteLine($"Erreur, réessayez: ");
}

Console.WriteLine($"Valeur convertie: {convertedValue}");