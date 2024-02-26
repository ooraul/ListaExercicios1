using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1ex4
{
    internal class Program
    {
        /*
         4. Construa um algoritmo para: ler três números (A, B e X). Em seguida, somar A com B e multiplicar
        o resultado por X, se X não for > 5; Subtrair B de A e multiplicar o resultado por X, caso contrário.
        Usar seleção (se).
         */
        static void Main(string[] args)
        {
            int a, b, x, res;
            Console.WriteLine("Digite o primeiro número");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro número");
            x = int.Parse(Console.ReadLine());

            if (!(x > 5)) res = (a + b) * x;
            else res = (a - b) * x;

            Console.WriteLine($"Resultado: {res}");
        }
    }
}
