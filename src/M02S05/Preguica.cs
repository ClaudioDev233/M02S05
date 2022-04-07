using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M02S05
{
    public class Preguica : Animal
    {
        public Preguica(string nome, int idade) : base(nome, idade)
        {
        }

        public void SubirEmArvore()
        {
            Console.WriteLine("Estou subindo na arvore");
        }

        public override void EmitirSom()
        {
            Console.WriteLine("Sonzinho da preguiça");
        }
    }
}
