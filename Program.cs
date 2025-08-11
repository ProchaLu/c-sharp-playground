namespace MyApp
{
  internal class Program
  {
    static void Main(string[] args)
    {
      int age = 38;
      string name = "Lukas";
      // Single quotes are used for single characters
      char letter = 'L';
      bool isActive = true;

      int x = 10, y = 20, z = 30;

      Console.WriteLine($"x: {x}, y: {y}, z: {z}");
      Console.WriteLine($"Sum of x, y, z: {x + y + z}");
      Console.WriteLine($"Product of x, y, z: {x * y * z}");
      Console.WriteLine($"Average of x, y, z: {(x + y + z) / 3.0}");
      Console.WriteLine("Hello World!");
      Console.WriteLine($"My name is {name} and I am {age} years old.");
      Console.WriteLine($"The first letter of my name is {letter}.");
      if (isActive)
      {
        Console.WriteLine("I am currently active.");
      }
      else
      {
        Console.WriteLine("I am not active at the moment.");
      }
      // assign new age
      age = 39;
      Console.WriteLine($"My updated age is {age}.");

      age++;

      Console.WriteLine($"My age after incrementing is {age}.");

      // Combine Strings
      string greeting = "Hello";
      greeting += " World!";
      Console.WriteLine($"Combined String: {greeting}");

      // Change String to different Number types
      StringToNumber.ConvertStringToNumber();

      // Format numbers
      FormatNumbers.FormatNumbersExample();

      // Call the RandomColor method from RandomColorGenerator
      RandomColorGenerator.RandomColor();

      // Call the DisplayDayOfWeek method from DaysOfTheWeekWithSwitchCases
      DaysOfTheWeekWithSwitchCases.DisplayDayOfWeek();
      Console.ReadLine();
    }
  }
}
