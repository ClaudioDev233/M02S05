using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M02S05
{
    public class Cavalo : Animal, ICorrer
    {
        public Cavalo(string nome, int idade) : base(nome, idade)
        {
        }

        public void Correr()
        {
            Console.WriteLine("Pocotó Pocotó Pocotó");

        }
        public override void EmitirSom()
        {
            Console.WriteLine("Relincho");
        }
    }
}
