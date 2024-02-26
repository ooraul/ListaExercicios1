using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1ex8
{
    internal class Program
    {
        // 8. Efetuar a leitura de cinco números inteiros (5 VARIAVEIS) e identificar o maior e o menor.
        static void Main(string[] args)
        {
            int a, b, c, d, e, menor, maior;
            Console.WriteLine("Digite o numero 1");
            a = int.Parse(Console.ReadLine());
            maior = a;
            menor = a;
            Console.WriteLine("Digite o numero 2");
            b = int.Parse(Console.ReadLine());
            if (b > maior) maior = b;
            if (b < menor) menor = b;
            Console.WriteLine("Digite o numero 3");
            c = int.Parse(Console.ReadLine());
            if (c > maior) maior = c;
            if (c < menor) menor = c;
            Console.WriteLine("Digite o numero 4");
            d = int.Parse(Console.ReadLine());
            if (d > maior) maior = d;
            if (d < menor) menor = d;
            Console.WriteLine("Digite o numero 5");
            e = int.Parse(Console.ReadLine());
            if (e > maior) maior = e;
            if (e < menor) menor = e;

            Console.WriteLine($"Maior número: {maior}");
            Console.WriteLine($"Menor número: {menor}");
        }
    }
}
