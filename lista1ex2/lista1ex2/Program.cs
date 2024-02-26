using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1ex2
{
    internal class Program
    {
        /*
         2. Construa um algoritmo para ler um número e mostrar uma mensagem dizendo se o número lido
        está entre 20 e 100 ou uma mensagem para caso o número não esteja nessa faixa.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número");
            int n = int.Parse(Console.ReadLine());
            if (n >= 20 && n <= 100) Console.WriteLine("O número está entre 20 e 100.");
            else Console.WriteLine("O número não está dentro da faixa.");
        }
    }
}
