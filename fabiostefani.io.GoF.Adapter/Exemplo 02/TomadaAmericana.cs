using System;

namespace fabiostefani.io.GoF.Adapter.Exemplo_02
{
    public class TomadaAmericana : ITomada<PlugAmericano>
    {
        public void Conecta(PlugAmericano plug)
        {
            Console.WriteLine(plug.ObtemEletricidade() + GetNomeRede());
        }

        public string GetNomeRede()
        {
            return "tomada americana";
        }
    }
}
