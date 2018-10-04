using System;

namespace fabiostefani.io.GoF.Adapter.Exemplo_02
{
    public class PlugBrasileiro : IPlug
    {
        
        public string ObtemEletricidade()
        {
            return "Plug brasileiro conectado a ";
        }
    }
}
