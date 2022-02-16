
using System;

namespace unirlista
{
     class Program
     {
         static void Main(string[] args)
         {
        List<string> num1 = new List<string>() { "1", "2", "3", "4" };
        List<string> num2 = new List<string>() { "1", "2", "5", "8" };
        num2.ForEach(num => num1.Add(num));
        Console.Write("junçao: ");
        Console.WriteLine(String.Join(",", num1));
         }
     }



}