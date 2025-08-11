public class StringToNumber
{
  public static void ConvertStringToNumber()
  {
    // Change String to Number
    string numberString = "42";
    int stringToNumber = Convert.ToInt32(numberString);
    Console.WriteLine($"Converted string '{numberString}' to number: {stringToNumber}");

    // Change to different Number types
    string textToBigNumber = "9223372036854775807";
    long bigNumber = Convert.ToInt64(textToBigNumber);
    Console.WriteLine($"Converted Number {bigNumber}");

    string textToNegativeNumber = "-12345";
    double negativeNumber = Convert.ToDouble(textToNegativeNumber);
    Console.WriteLine($"Converted negative number: {negativeNumber}");

    string textToPrecisionNumber = "3.14159";
    float precisionNumber = Convert.ToSingle(textToPrecisionNumber);
    Console.WriteLine($"Converted precision number: {precisionNumber}");

    string textToMoney = "19.99";
    decimal money = Convert.ToDecimal(textToMoney);
    Console.WriteLine($"Converted money value: {money}");
  }
}
