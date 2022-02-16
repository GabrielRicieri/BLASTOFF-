using System;
 
 namespace mediaIdade
 {
     class Program
     {
         static void Main(string[] args)
         {
             Console.WriteLine("Informe a idade de 5 pessoas, para calcular a media entre eles");
            var somatotal = 0;
            var divisor = 0;
             for(int i = 0; i < 5; i++){

                 Console.WriteLine($"Informe a idade da {divisor} pessoa");

                 var idade = Console.ReadLine();
                 somatotal +=  Convert.ToInt32(idade);
                 divisor++;

             }
            Console.WriteLine($"a media é :{somatotal/divisor}");

         }
     }
 }