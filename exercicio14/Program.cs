
using System;

namespace Palindromo
{
     class Program
     {
         static void Main(string[] args)
         {
             string palavra;
             Console.WriteLine("digite a palavra para ser verificada");
             palavra = Console.ReadLine();

             int x  = palavra.Length-1;

             while( x != -1){
                 for(int i =0 ; i < palavra.Length; i++){
                     if(palavra[i]== palavra[x])
                     {
                         if(x ==0){
                             Console.WriteLine("è palindromo");
                             Console.ReadLine();
                         }
                         x--;
                     }else{
                         Console.WriteLine("nao é palindromo");
                         i = palavra.Length;
                         x = -1;

                         Console.ReadLine();
                     }
                 }
             }
         }
     }



}
