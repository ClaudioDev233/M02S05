using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M02S05
{
    public class Cachorro : Animal, ICorrer
    {
        public Cachorro(string nome, int idade) : base(nome, idade)
        {
        }

        public void Correr()
        {
            Console.WriteLine("Cachorrin Correndo");
        }

        public override void EmitirSom()
        {
            Console.WriteLine("Au au au");
        }
    }
}
