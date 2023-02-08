namespace PointerPrak1
{
  class Program
  {
    static void Main(string[] args)
    {
      unsafe
      {
        int age = 32;
        int* age_ptr = &age;
        Console.WriteLine("age = {0}", age);
        *age_ptr += 3;
        Console.WriteLine("age_ptr = {0}", *age_ptr);
        Console.ReadLine();
      }
    }
  }
}