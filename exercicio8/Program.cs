
using System;

namespace Primo
{
     class Program
     {
         static void Main(string[] args)
         {
                int num = 479001599 ;
                int div= 0;
                 Console.WriteLine("informe um numero");
                 num = Convert.ToInt32(Console.ReadLine());


                 for(int i=2; i<= num/2;  i++){

                     if(num % i == 0 );
                     div ++;

                 }

                 if(div == 0){
                     Console.WriteLine("é um numero primo");
                 }else
                     Console.WriteLine("N é um numero primo");
                 

                   Console.ReadKey();

         }
     }



}