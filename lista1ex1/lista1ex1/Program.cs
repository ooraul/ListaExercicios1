using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1ex1
{
    internal class Program
    {
        /*
         1. Efetuar a leitura de dois valores, realizar a soma e verificar se o resultado é maior que 10. caso sim,
         mostre resultado + 5, senão, mostre resultado -7.
         */
        static void Main(string[] args)
        {
            int a, b, soma;
            Console.WriteLine("Digite o primeiro número");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            b = int.Parse(Console.ReadLine());
            soma = a + b;
            if (soma > 10) Console.WriteLine(soma+5);
            else Console.WriteLine(soma-7);
        }
    }
}
