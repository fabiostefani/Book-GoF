using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabiostefani.io.GoF.Facade.Entidades
{
    public interface ICartao
    {
        bool ValidarCartao(string numeroCartao);
        ICorrentista ObterCorrentista();
    }
    public class Cartao : ICartao
    {
        private ICorrentista correntista;
        public Cartao()
        {
            
        }

        public bool ValidarCartao(string numeroCartao)
        {
            this.correntista = new Correntista();
            return true;
        }

        public ICorrentista ObterCorrentista()
        {
            return this.correntista;
        }
    }
}
