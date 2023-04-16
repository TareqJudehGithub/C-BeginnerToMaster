namespace Arrays
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Arrays\n");

      // Arrays
      string[] myGrocery = new string[5];
      myGrocery[0] = "milk";
      Console.WriteLine(myGrocery[0]);

      myGrocery[1] = "bread";

      // Editing
      myGrocery[0] = "No Item";
      Console.WriteLine(myGrocery[0]);

      // Two dimensional Array
      string[,] cart = new string[,]  {
      { "Oranges", "Cereal" },
      {"Toilet Paper", "Kitchen Napkins"}
    };
      // Accessing items inside a two-dimensional array

      // Outputting Cereal
      Console.WriteLine(cart[0, 1]);

    }
  }
}
