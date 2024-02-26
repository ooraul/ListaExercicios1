using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1ex7
{
    internal class Program
    {
        /*
         7. Efetuar a leitura de 3 números inteiros (3 VARIAVEIS) apresentá-los em ordem crescente. Utilize
        uma seleção encadeada. (NÃO USAR VETOR)
         */
        static void Main(string[] args)
        {
            int a, b, c, menor, medio = 0, maior = 0;
            Console.WriteLine("Digite o primeiro número");
            a = int.Parse(Console.ReadLine());
            if (a > maior) maior = a;
            menor = a;
            Console.WriteLine("Digite o segundo número");
            b = int.Parse(Console.ReadLine());
            if (b > maior) maior = b;
            if (b < menor) menor = b;
            Console.WriteLine("Digite o terceiro número");
            c = int.Parse(Console.ReadLine());
            if (c > maior) maior = c;
            if (c < menor) menor = c;
            if (a == maior)
                if (b > c) medio = b;
                else medio = c;
            if (b == maior)
                if (a > c) medio = a;
                else medio = c;
            if (c == maior)
                if (a > b) medio = a;
                else medio = b;

            Console.WriteLine("===== ORDEM CRESCENTE =====");
            Console.WriteLine(menor);
            Console.WriteLine(medio);
            Console.WriteLine(maior);
        }
    }
}
