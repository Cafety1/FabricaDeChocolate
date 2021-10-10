using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Loja;

namespace Fabrica
{
    public class FabricaDeChocolate
    {

        
        public Chocolate CriarChocolate(string tipo)
        {
            var chocolate = new Chocolate();
            chocolate.Tipo = tipo;
            return chocolate;
                     
        }
    }
}
