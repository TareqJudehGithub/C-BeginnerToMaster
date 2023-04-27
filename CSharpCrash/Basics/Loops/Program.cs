namespace Loops;
class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Hello, World!\n");

    int[] intsToCompress = new int[] { 15, 5, 17, 10, 3, 155, 2, 12, 24 };

    // Workout the sum of intsToCompress 
    int sum = 0;
    for (int i = 0; i < intsToCompress.Length; i++)
    {
      sum += intsToCompress[i];
    }
    // Workout the average of intsToCompress
    int avg = sum / intsToCompress.Length;

    // Output the highest value intsToCompress
    int highestNum = 0;
    for (int i = 0; i < intsToCompress.Length; i++)
    {
      if (intsToCompress[i] > highestNum) highestNum = intsToCompress[i];
    }

    // Output the lowest value intsToCompress
    Console.WriteLine($"Lowest Num solution");
    int lowestNum = 0;
    lowestNum = intsToCompress[0];

    for (int i = 0; i < intsToCompress.Length; i++)
    {
      if (intsToCompress[i] < lowestNum)
      {
        lowestNum = intsToCompress[i];
      }
      Console.WriteLine($"current lowest No. = {lowestNum}");
    }

    Console.WriteLine(sum);
    Console.WriteLine(avg);
    Console.WriteLine($"Highest Num = {highestNum}");
    Console.WriteLine($"Lowest Num = {lowestNum}");

    // Foreach loop
    System.Console.WriteLine("/nForeach loop");
    // Output the even numbers 
    foreach (int num in intsToCompress)
    {
      if (num % 2 == 0)
      {
        Console.WriteLine($"{num} is an even number.");
      }
      else
      {
        Console.WriteLine($"{num} is an odd number.");
      }
    }
    System.Console.WriteLine("/nFizzBuzz/n");
    for (int i = 1; i < 20; i++)
    {
      if (i % 3 == 0) System.Console.WriteLine($"({i}) FIZZ");
      else if (i % 5 == 0) System.Console.WriteLine($"({i}) Buzz");
      else if (i % 3 == 0 && i % 5 == 0) System.Console.WriteLine($"({i}) FIZZBUZZ");
      else System.Console.WriteLine("");
    }

  }


}
