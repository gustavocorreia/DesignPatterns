using DesignPatterns.FactoryMethod.Interfaces;
using System;

namespace DesignPatterns.FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var factoryMethod = new PersonagensFactoryMethod();

            Console.WriteLine("Liu Kang | SubZero | Scorpion");
            Console.WriteLine();

            Console.Write("Escolha um Personagem: ");
            string escolha = Console.ReadLine();

            IPersonagem personagem = factoryMethod.EscolherPersonagem(escolha);

            Console.WriteLine();
            Console.Write("Você vai jogar com ");
            personagem.Escolhido();

            Console.ReadKey();
        }
    }
}
