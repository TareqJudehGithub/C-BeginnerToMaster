namespace IEnumerable;
class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("IEnumerable\n");

    // new list
    List<string> groceryList = new List<string>() { "Milk", "Bread", "Cereal" };

    IEnumerable<string> groceryListIEnumerable = groceryList;

    // Output the 1st element in the INumerable 
    Console.WriteLine(groceryListIEnumerable.First());

  }
}
