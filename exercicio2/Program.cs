using System;

namespace Mediagasolina
{
     class Program
     {
         static void Main(string[] args)
         {
            int distancia = 0;
            int gasto = 0;
            
            Console.WriteLine("Informe a distancia percorrida");
           distancia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o quando de litros foi gasto");
           gasto = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"a media é :{distancia/gasto}");
         }
     }



}
