using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1ex6
{
    internal class Program
    {
        /*
         6. Elaborar um algoritmo que efetue a leitura de um valor numérico inteiro e apresente-o caso esse
        valor não seja divisível por 4. Caso contrário deverá ser emitida uma mensagem de número inválido.
        Use o mod e, em seguida, faça o algoritmo sem esta função. Usar seleção (se).
         */
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Digite um número");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("===== COM MOD =====");
            if (!(n%4==0)) Console.WriteLine($"{n} não é divisível por 4.");
            else Console.WriteLine("número inválido");
            Console.WriteLine("===== SEM MOD =====");
            if ((double)n/4 != n/4) Console.WriteLine($"{n} não é divisível por 4.");
            else Console.WriteLine("número inválido");
        }
    }
}
