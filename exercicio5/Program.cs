

using System;

namespace multiplos
{
     class Program
     {
         static void Main(string[] args)
         {
            int n1 =0, n2=0;
            Console.WriteLine("digite o primeiro numero");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite o segundo numero");
            n2 = Convert.ToInt32(Console.ReadLine());

            if( n1%n2 == 0){

                 Console.WriteLine("é multiplo");

            }
            else {
                Console.WriteLine(" N é multiplo");
            }
         }
     }



}