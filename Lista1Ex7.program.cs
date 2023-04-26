using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.WriteLine("Realizando: conversão milhas marítimas para quilômetros:");
            Console.Write("Digite o valor em milhas marítimas:");
            a = double.Parse(Console.ReadLine());

            b = a*1852/1000;
            Console.WriteLine($"A conversão resultou em {b}Km.");

        }
    }
}
