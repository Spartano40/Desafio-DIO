using System;
class DIO {
        
static void Main(string[] args){

        int numeroEntrada = int.Parse(Console.ReadLine());
        int produto = 1, soma = 0;
        while (numeroEntrada > 0){
             int l = numeroEntrada % 10;

             produto *= l;
             soma += l;
             numeroEntrada /= 10;
           }

           Console.WriteLine(produto-soma);
        }
    }