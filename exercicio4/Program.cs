

using System;

namespace tempratura
{
     class Program
     {
         static void Main(string[] args)
         {
          double f= 0;
          double c = 0 ;

          Console.WriteLine("Informe a temperatura em fahtenheit");
          f = double.Parse(Console.ReadLine());

          c= (double)5/9 *(f-32);

          Console.WriteLine("Temperatura convertida em celcius é :"+ c );
          Console.ReadKey();      

         }
     }



}