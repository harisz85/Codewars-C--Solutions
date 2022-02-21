using System;
using System.Linq;
using System.Collections.Generic;



//In this little assignment you are given a string of space separated numbers, and have to return the highest and lowest number.
//Examples

//Kata.HighAndLow("1 2 3 4 5");  // return "5 1"
//Kata.HighAndLow("1 2 -3 4 5"); // return "5 -3"
//Kata.HighAndLow("1 9 3 4 -5"); // return "9 -5"






public static class Kata
{
    public static string HighAndLow(string numbers)
    {

        string[] arr = numbers.Split(' ');

        int max = int.MaxValue;
        int min = int.MinValue;

        for (int i = 0; i < arr.Length; i++)
        {
            int res = Convert.ToInt32(arr[i]);

            if (max > res) { max = res; }
            if (min < res) { min = res; }


        }


        return $"{min} {max}";
    }
}