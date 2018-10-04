using System;

namespace fabiostefani.io.GoF.Adapter.Exemplo_02
{
    public class TomadaBrasileira : ITomada<PlugBrasileiro>
    {
        
        public void Conecta(PlugBrasileiro plug)
        {
            Console.WriteLine(plug.ObtemEletricidade() + GetNomeRede());
        }

        public string GetNomeRede()
        {
            return "tomada brasileira";
        }
    }
}
