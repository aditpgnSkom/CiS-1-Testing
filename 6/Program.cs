using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace StackPOP
{
  class Program
  {
    static Stack<int> GetStack()
    {
      Stack<int> stack = new Stack<int>();
      stack.Push(100);
      stack.Push(1000);
      stack.Push(10000);
      return stack;
    }
    static void Main()
    {
      // Get the stack [See above definition of this method]
      Stack<int> stack = GetStack();
      // Pop the top element
      int pop = stack.Pop();
      // Write to the console
      Console.WriteLine("--- Element popped from top of Stack ---");
      Console.WriteLine(pop);
      // Now look at the top element
      int peek = stack.Peek();
      Console.WriteLine("--- Element now at the top ---");
      Console.WriteLine(peek);
      Console.ReadLine();
    }
  }
}