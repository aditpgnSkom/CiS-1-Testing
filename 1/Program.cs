using System;
namespace UnsafeCodeApplication
{
  class Program
  {
    static unsafe void Main(string[] args)
    {
      int var = 20;
      int* p = &var;
      *p = 35;
      Console.WriteLine("Data is: {0}", var);
      Console.WriteLine("Address is: {0}", (int)p);
      Console.ReadKey();
    }
  }
}