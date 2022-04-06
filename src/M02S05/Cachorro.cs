using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M02S05
{
    public class Cachorro : Animal, ICorrer
    {
        public void Correr()
        {
            Console.WriteLine("Cachorrin Correndo");
        }
    }
}
