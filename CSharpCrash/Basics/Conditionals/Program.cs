//namespace Conditionals;
class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Conditionals\n");

    int myInt = 5;
    int mySecondInt = 10;

    string name = "john";
    string upperName = "JOHN";

    // Check if myInt is bigger than mySecondInt
    if (myInt > mySecondInt) Console.WriteLine($"myInt > mySecondint ? Answer = {true}");
    else Console.WriteLine($"myInt > mySecondint ? Answer = {false}");

    System.Console.WriteLine("\n");

    // Check if name equals upperName
    if (name.Equals(upperName)) System.Console.WriteLine("Both string are equals");
    else System.Console.WriteLine("String in both variables are not equals");
    // Switch statements
    string todayIs = "";
    todayIs = "Thursday";
    string answer;
    switch (todayIs)
    {
      case "Wednesday":
        answer = "Today is Wednesday";
        break;
      case "Thursday":
        answer = " Today is Thursday\nIt is the weekend's Eve :)";
        break;
      default:
        answer = "Invalid entry";
        break;
    }

    System.Console.WriteLine(answer);
  }


}
