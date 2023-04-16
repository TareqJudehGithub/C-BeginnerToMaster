namespace Conditionals;
class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Conditionals & Operators\n");

    int numA = 5;
    int numB = 6;

    bool isEqual = numA > numB;

    Console.WriteLine($"Is {numA} > {numB} ? Result = {isEqual}");

    string wordA = "1";
    int wordB = 1;

    System.Console.WriteLine(wordA.Equals(wordB));
    //System.Console.WriteLine(wordA == wordB);
    System.Console.WriteLine(0.002 - 0.001);
  }
}
