using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1ex9
{
    internal class Program
    {
        /*
         9. Efetuar a leitura de um número inteiro e apresentar uma mensagem informando se o número é par
         ou ímpar. Usar seleção (se).
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um numero inteiro");
            int n = int.Parse(Console.ReadLine());
            if (n%2==0) Console.WriteLine("é par :)");
            else Console.WriteLine("é ímpar :(");
        }
    }
}
