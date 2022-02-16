
using System;

namespace horajogo
{
     class Program
     {
         static void Main(string[] args)
         {
        Console.WriteLine("Digite a data e hora da entrada");

        String dataEntrada = Console.ReadLine();

        Console.WriteLine(dataEntrada);

        Console.WriteLine("Digite a data e hora da saída");

        String dataSaida = Console.ReadLine();

        Console.WriteLine(dataSaida);

        if (dataSaida < horaInicio)
            {
            dataSaida = dataSaida.AddDays(1);
                }

        var tempo = dataSaida - dataEntrada;

        Console.WriteLine("a hora é :"+ tempo);

         }
     }



}