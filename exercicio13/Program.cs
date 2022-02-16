
using System;

namespace tempratura
{
     class Program
     {
         static void Main(string[] args)
         {
             string[,]num = new string [3 ,2];
             num[0,0]  = "MARCOS";
             num[0,1]   = "2";

             num[1,0]   = "JOAO";
             num[1,1]   = "4";

             num[2,0]   = "GABRIEL";
             num[2,1]   = "6";

            string nums = "";                
             for(int  linha = 0;linha<3; linha ++)
             {
                for(int col = 0 ; col <2; col++){
                     nums+= num[linha,col]+ " ";
                 }
                 Console.WriteLine(nums);
                
             }
     
         }
     }



}
