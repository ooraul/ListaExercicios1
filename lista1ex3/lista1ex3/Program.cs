using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1ex3
{
    internal class Program
    {
        /*
         3. Construa um algoritmo para ler o sexo de uma pessoa (M ou F). Uma mensagem deverá ser emitida
        caso o sexo seja válido.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o sexo da pessoa (M / F)");
            char s = char.Parse(Console.ReadLine().ToUpper());
            if (s == 'M' || s == 'F') Console.WriteLine($"O sexo é válido ({s}).");
        }
    }
}
