// This Random Color Generator is designed to generate a random color, and color a console output with it.
// As an update, the user can also specify a color and luminosity level to generate a color based on those parameters.
using System;

public class RandomColorGenerator
{
  public static void RandomColor()
  {
    var random = new Random();
    var colors = (ConsoleColor[])Enum.GetValues(typeof(ConsoleColor));
  }
}
