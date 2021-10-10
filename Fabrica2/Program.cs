using Fabrica;
using System;

namespace Fabrica2
{
    class Program
    {
        static void Main(string[] args)
        {
            var fabrica = new FabricaDeChocolate();
            var chocolate = fabrica.CriarChocolate("Dark");
            chocolate.PorcentagemDeAcucar = 30.0f;
            var perc = chocolate.PorcentagemDeCacau;

            Console.WriteLine(chocolate.Tipo);
            Console.WriteLine(perc);
        }
    }
}
