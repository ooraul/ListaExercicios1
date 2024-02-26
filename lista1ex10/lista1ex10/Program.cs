using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1ex10
{
    internal class Program
    {
        /*
         10. Faça um algoritmo que leia o ano de nascimento de uma pessoa, calcule e mostre sua idade e,
        também, verifique e mostre se ela já tem idade para votar (16 anos ou mais) e para conseguir a C.N.H
        (18 anos ou mais).
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Insira seu ano de nascimento");
            int ano = int.Parse(Console.ReadLine());
            int idade = 2024 - ano;

            Console.WriteLine($"Idade = {idade}");
        
            if (idade >= 16) Console.WriteLine("Pode votar");
            if (idade >= 18) Console.WriteLine("Pode tirar a CNH");
        }
    }
}
