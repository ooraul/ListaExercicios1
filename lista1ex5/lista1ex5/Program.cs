using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1ex5
{
    internal class Program
    {
        /*
         5. Dados três valores A, B, C, verificar se eles podem ser os comprimentos dos lados de um triângulo
        e, se forem, verificar se compõem um triângulo eqüilátero, isósceles ou escaleno. Informar se não
        compuserem nenhum triângulo. Usar seleção (se).
        Dados de saída: mensagens (não compõem o triângulo, triângulo eqüilátero, triângulo isósceles,
        triângulo escaleno).
        Triângulo: figura geométrica de três lados, em que cada um é menor do que a soma dos outros dois.
        T. eqüilátero: um triângulo com três lados iguais.
        T. isósceles: um triângulo com dois lados iguais.
        T. escaleno. Um triângulo com todos os lados diferentes.
         */
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Digite o primeiro número");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro número");
            c = int.Parse(Console.ReadLine());

            if (a < b + c && b < a + c && c < a + b)
            {
                if (a == b && b == c) Console.WriteLine("triângulo equilátero");
                else if (a != b && b != c) Console.WriteLine("triângulo escaleno");
                else Console.WriteLine("triângulo isósceles");
            } else Console.WriteLine("não compõem o triângulo");
        }
    }
}
