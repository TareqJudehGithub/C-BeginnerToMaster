namespace Lists;
class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Lists\n");

    // Define a new list
    List<string> groceryList = new List<string>() { "milk", "cheese" };

    // Outputs the 1st item in the List
    Console.WriteLine(groceryList[0]);

    // Add a new item into the list
    groceryList.Add("Potato");
    Console.WriteLine(groceryList[2]);

  }
}
