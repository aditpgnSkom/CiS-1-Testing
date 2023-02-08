using System;
using System.Collections;
public class SampleStack
{
  public static void Main()
  {
    //Creates and initializes a new stack.
    Stack myStack = new Stack();
    // myStack.Push("Hello");
    // myStack.Push("World");
    // myStack.Push("!");

    //input stack
    Console.Write("Jml\t: ");
    int jml = Convert.ToInt32(Console.ReadLine());

    for(int i = 0; i < jml; i++)
    {
      Console.Write("Data ke-{0}", i+1, "\t: ");
      myStack.Push(Console.ReadLine());
    }

    //Displays the properties and values of the stack.
    Console.WriteLine("myStack");
    Console.WriteLine("\tCount: {0}", myStack.Count);
    Console.WriteLine("\tValues:");
    PrintValues(myStack);
  }

  public static void PrintValues(IEnumerable myCollection)
  {
    foreach (Object obj in myCollection)
      Console.Write("   {0}", obj);
      Console.WriteLine();
      Console.ReadLine();
  }
}