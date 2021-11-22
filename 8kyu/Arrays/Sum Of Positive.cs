using System;
using System.Linq;

public class Kata
{
  public static int PositiveSum(int[] arr)
  {
    
   int sum = 0;
    
   foreach(int item in arr) {
     if ( item > 0) {
       sum += item;
     }
   }
    
    return sum;
  }
}