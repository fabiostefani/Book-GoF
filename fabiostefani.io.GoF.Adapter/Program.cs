using fabiostefani.io.GoF.Adapter.Exemplo_02;
using System;

namespace fabiostefani.io.GoF.Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exemplo 01");
            new Target().Request();
            new Adapter().Request();

            Console.WriteLine("Exemplo 02");

            new TomadaBrasileira().Conecta(new PlugBrasileiro());
            new TomadaAmericana().Conecta(new PlugAmericano());

            new AdapterEUAToBrasil().Conecta(new PlugAmericano());

            Console.ReadKey();
        }
    }
}
