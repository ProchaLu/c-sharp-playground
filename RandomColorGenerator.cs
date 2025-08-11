// This Random Color Generator is designed to generate a random color, and color a console output with it.
// As an update, the user can also specify a color and luminosity level to generate a color based on those parameters.
public class RandomColorGenerator
{
  public static void RandomColor()
  {
    var random = new Random();
    var colors = (ConsoleColor[])Enum.GetValues(typeof(ConsoleColor));
    Console.WriteLine("Random Color: " + colors[random.Next(colors.Length)]);

    // Color a string after a user input
    Console.WriteLine("Enter a color name (e.g., Red, Green, Blue):");
    string userColor = Console.ReadLine() ?? string.Empty;
    Console.WriteLine($"Your chosen color is: {userColor} ");
    // Color the string output with the specified color
    if (Enum.TryParse(userColor, true, out ConsoleColor color))
    {
      Console.ForegroundColor = color;
      Console.WriteLine($"This text is colored in {userColor}.");
      // Reset the color to default after coloring the text
      Console.ResetColor();
    }
    else
    {
      Console.WriteLine("Invalid color name. Using default color.");
    }
  }
}
