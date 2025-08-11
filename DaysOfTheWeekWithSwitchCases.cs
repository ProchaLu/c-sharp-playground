public class DaysOfTheWeekWithSwitchCases
{
  public static void DisplayDayOfWeek()
  {

    Console.WriteLine("Enter a number (1-7) to get the corresponding day of the week:");
    int dayNumber = int.Parse(Console.ReadLine() ?? "0");


    switch (dayNumber)
    {
      case 1:
        Console.WriteLine("Monday");
        break;
      case 2:
        Console.WriteLine("Tuesday");
        break;
      case 3:
        Console.WriteLine("Wednesday");
        break;
      case 4:
        Console.WriteLine("Thursday");
        break;
      case 5:
        Console.WriteLine("Friday");
        break;
      case 6:
        Console.WriteLine("Saturday");
        break;
      case 7:
        Console.WriteLine("Sunday");
        break;
      default:
        Console.WriteLine("Invalid day number. Please enter a number between 1 and 7.");
        break;
    }
  }
}
