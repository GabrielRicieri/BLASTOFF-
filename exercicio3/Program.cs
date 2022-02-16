

using System;

namespace Menornumero
{
     class Program
     {
         static void Main(string[] args)
         {
             int n = 0,  menor = 0 ;
             Console.WriteLine("Determinar o menor numero");
             Console.WriteLine("Informe o 1 numero");
             n = Convert.ToInt32(Console.ReadLine());
             menor = n;
             Console.WriteLine("Informe o 2 numero");
               n = Convert.ToInt32(Console.ReadLine());
               if( n < menor){
                   menor = n;
               }
             Console.WriteLine("Informe o 3 numero");
              n = Convert.ToInt32(Console.ReadLine());
               if( n < menor){
                   menor = n;
               }

               Console.WriteLine(") menor numero informado é :" +menor);
               Console.ReadKey();

         }
     }



}