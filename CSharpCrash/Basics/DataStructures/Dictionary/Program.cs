namespace Dictionary;
class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Dictionary\n");

    Dictionary<string, string[]> GroceryDict = new Dictionary<string, string[]>()
    {
        {"Dairy", new string[]{"Milk", "Cheese", "Yoghurt"}},
        {"Juice", new string[]{"Orange Juice", "Apple Juice"}}
    };

    // Output Cheese
    Console.WriteLine(GroceryDict["Dairy"][1]);

    // Output Orange Juice
    Console.WriteLine(GroceryDict["Juice"][0]);
  }
}
