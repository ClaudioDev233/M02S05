using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M02S05
{
    public abstract class Animal
    {
        protected Animal(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public string Nome { get; private set; }
        public int Idade { get; private set; }

        public virtual void EmitirSom()
        {
            Console.WriteLine("Som Default");
        }
    }
}
