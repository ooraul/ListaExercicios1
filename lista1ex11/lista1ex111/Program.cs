using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1ex111
{
    internal class Program
    {
        /*
         11. Construa um algoritmo que seja capaz de concluir qual dentre os seguintes animais foi escolhido,
        através de perguntas e respostas. Animais possíveis: leão, cavalo, homem, macaco, morcego, baleia,
        avestruz, pingüim, pato, águia, tartaruga, crocodilo e cobra.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("O animal é mamífero? (s/n)");
            if (Console.ReadLine().ToLower()[0] == 's')
            {
                Console.WriteLine("O animal é um quadrúpede? (s/n)");
                if (Console.ReadLine().ToLower()[0] == 's')
                {
                    Console.WriteLine("O animal é carnívoro? (s/n)");
                    if (Console.ReadLine().ToLower()[0] == 's') Console.WriteLine("O animal é um Leão!");
                    else Console.WriteLine("O animal é um Cavalo!");
                } else
                {
                    Console.WriteLine("O animal é bípede? (s/n)");
                    if (Console.ReadLine().ToLower()[0] == 's')
                    {
                        Console.WriteLine("O animal é Onívoro? (s/n)");
                        if (Console.ReadLine().ToLower()[0] == 's') Console.WriteLine("O animal é um Homem!");
                        else Console.WriteLine("O animal é um Macaco!");
                    } else
                    {
                        Console.WriteLine("O animal é voador? (s/n)");
                        if (Console.ReadLine().ToLower()[0] == 's') Console.WriteLine("O animal é um Morcego!");
                        else Console.WriteLine("O animal é uma Baleia!");
                    }
                }
            } else
            {
                Console.WriteLine("O animal é uma ave? (s/n)");
                if (Console.ReadLine().ToLower()[0] == 's')
                {
                    Console.WriteLine("O animal voa? (s/n)");
                    if(Console.ReadLine().ToLower()[0] == 's')
                    {
                        Console.WriteLine("O animal é carnívoro? (s/n)");
                        if (Console.ReadLine().ToLower()[0] == 's') Console.WriteLine("O animal é uma Águia!");
                        else Console.WriteLine("O animal é um Pato!");
                    } else
                    {
                        Console.WriteLine("O animal é onívoro? (s/n)");
                        if (Console.ReadLine().ToLower()[0] == 's') Console.WriteLine("O animal é um Avestruz!");
                        else Console.WriteLine("O animal é Pinguim!");
                    }
                } else
                {
                    Console.WriteLine("O animal é aquático? (s/n)");
                    if (Console.ReadLine().ToLower()[0] == 's')
                    {
                        Console.WriteLine("O animal é carnívoro? (s/n)");
                        if (Console.ReadLine().ToLower()[0] == 's') Console.WriteLine("O animal é um Crocodilo!");
                        else Console.WriteLine("O animal é uma Tartaruga!");
                    }
                    else Console.WriteLine("O animal é uma Cobra!"); // fim
                }
            }
        }
    }
}
