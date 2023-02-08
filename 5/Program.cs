﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace StackPush
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
      var stack = GetStack();
      Console.WriteLine("--- Stack contents ---");
      foreach (int i in stack)
      {
        Console.WriteLine(i);
      }
      Console.ReadLine();
    }
  }
}