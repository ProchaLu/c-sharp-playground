using System.Runtime.CompilerServices;

public class FormatNumbers
{
  public static void FormatNumbersExample()
  {
    // Example of formatting numbers
    double number = 1.23456789;
    Console.WriteLine($"Default format: {number}");
    Console.WriteLine($"no decimal: {number:N0}");
    Console.WriteLine($"2 decimal places: {number:N2}");
    Console.WriteLine($"Currency format: {number:C}");
    Console.WriteLine($"Percentage format: {number:P}");
    Console.WriteLine($"Custom format: {number:#,##0.00}");
  }
}
