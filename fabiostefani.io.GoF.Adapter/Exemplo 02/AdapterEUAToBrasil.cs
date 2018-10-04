using System;

namespace fabiostefani.io.GoF.Adapter.Exemplo_02
{
    public class AdapterEUAToBrasil : TomadaBrasileira
    {
        public void Conecta(PlugAmericano plug)
        {
            Console.WriteLine(plug.ObtemEletricidade() + GetNomeRede());
        }
    }
}
