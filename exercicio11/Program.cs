
using System;

namespace intersesao
{
     class intersecao
     {
         static void Main(string[] args)
         {
         List<string> num1 = new List<string>() { "1", "2", "3", "4" };
        List<string> num2 = new List<string>() { "1", "2", "5", "8" };
        List<string> list2 = new List<string>() {  };
        num1 = num2.Intersect(list2).ToList();
        Console.Write("intersecao: "+list2);
        
         }
         }
     }




