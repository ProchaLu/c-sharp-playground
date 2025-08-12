public class TimesTable
{
  public static void DisplayTimesTable()
  {
    Console.WriteLine("Enter a number to display its times table:");
    if (int.TryParse(Console.ReadLine(), out int number))
    {
      Console.WriteLine($"Times table for {number}:");
      for (int i = 1; i <= 10; i++)
      {
        // Alternative write method
        // Console.WriteLine($"{a} x {b} = {a * b}", number, i, number * i);
        Console.WriteLine($"{number} x {i} = {number * i}");
      }
    }
    else
    {
      Console.WriteLine("Invalid input. Please enter a valid number.");
    }
  }
}
