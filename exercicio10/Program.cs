
using System;

namespace fatorial
{
     class Program
     {
         static void Main(string[] args)
         {
              int x, fat = 1, result =0;
                Console.WriteLine("digite o numero");
                x = Convert.ToInt32(Console.ReadLine());

                for(; x >=1 ; -- x){
                    result = fat *= x;
                }

                 Console.WriteLine("o fatorial é :" +result);
 
         }
     }



}