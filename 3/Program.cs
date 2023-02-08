namespace PointerPRak1
{
  class Program
  {
    static void Main(string[] args)
    {
      //normal pointer to an object
      int[] a = new int[5] {10, 20, 30, 40, 50};
      //must be unsafe code to use interior pointer
      unsafe
      {
        //must pin object on heap so that it does not move while using interior pointer
        fixed (int* p = &a[0])
        {
          //p is pinned as well as object, so create another pointer to show incrementing it
          int* p2 = p;
          Console.WriteLine(*p2);
          //incrementing p2 bumps the pointer by four bytes due to itd type
          p2 += 1;
          Console.WriteLine(*p2);
          p2 += 1;
          Console.WriteLine(*p2);
          Console.WriteLine("--------");
          Console.WriteLine(*p);
          //deferencing p and incrementing changes the value of a[0]
          *p += 1;
          Console.WriteLine(*p);
          *p += 1;
          Console.WriteLine(*p);
        }
      Console.ReadLine();
      }
    }
  }
}