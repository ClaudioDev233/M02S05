using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M02S05
{
    public class Veterinario
    {
        public void Examinar(Animal animal)
        {
            animal.EmitirSom();
        }
    }
}
