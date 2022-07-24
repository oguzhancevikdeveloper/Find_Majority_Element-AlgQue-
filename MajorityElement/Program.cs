using System;

namespace MajorityElement
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] myList = {1,1,1,2,2,3,4,4,1,1,3,3,3,3,3,3,3};
      int result = 0;
      int count = 0;

      foreach (var item in myList)
      {
        if(count == 0)
        {
          result = item;
          if (item == result)
          {
            count++;
          }
        }
        else
        {
          count--;
        }
      }
      Console.WriteLine("En çok tekrar eden sayı: " + result);
      Console.ReadLine();
    }
  }
}
