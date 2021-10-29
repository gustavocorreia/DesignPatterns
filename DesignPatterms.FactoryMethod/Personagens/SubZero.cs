using DesignPatterns.FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod.Personagens
{
    public class SubZero : IPersonagem
    {
        public void Escolhido()
        {
            Console.WriteLine("SubZero");
        }
    }
}
