using System;

namespace fabiostefani.io.GoF.Adapter.Exemplo_02
{
    public class PlugAmericano : IPlug
    {
        
        public string ObtemEletricidade()
        {
            return "Plug Americano conectado a ";
        }
    }
}
