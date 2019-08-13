using Pizzaria.Model;
using System;

namespace Pizzaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza = new Pizza();
            Console.Write("Nome : "); ;
            pizza.Nome = Console.ReadLine();
            
            Console.Write("Codigo : "); ;
            pizza.Codigo = Console.ReadLine();

            Console.Write("Preco : "); ;
            pizza.Preco = Console.ReadLine();

            Console.Write("Descricao : "); ;
            pizza.Descricao = Console.ReadLine();

            Console.WriteLine($"vc escolheu {pizza.Nome} {pizza.Codigo} {pizza.Preco} {pizza.Descricao}");


        }
    }
}
