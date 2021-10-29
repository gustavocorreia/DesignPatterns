using DesignPatterns.FactoryMethod.Interfaces;
using DesignPatterns.FactoryMethod.Personagens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod
{
    public class PersonagensFactoryMethod
    {
        public IPersonagem EscolherPersonagem(string personagem)
        {
            switch(personagem)
            {
                case "Liu Kang": return new LiuKang();
                case "SubZero": return new SubZero();
                case "Scorpion": return new Scorpion();
                default: return null;
            }
        }
    }
}
