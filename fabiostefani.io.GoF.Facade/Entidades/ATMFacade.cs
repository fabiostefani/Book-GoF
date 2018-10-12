using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabiostefani.io.GoF.Facade.Entidades
{
    public class ATMFacade
    {
        private ICartao _cartao;
        private ICorrentista _correntista;
        private IConta _conta;
        private IDeposito _deposito;
        private IEmprestimo _emprestimo;
        private IPagamento _pagamento;
        private ISaque _saque;
        public ATMFacade(string numeroCartao)
        {
            _cartao = new Cartao();
            if (_cartao.ValidarCartao(numeroCartao))
            {
                _correntista = _cartao.ObterCorrentista();
                _conta = new Conta(_correntista);
            }
            _deposito = new Deposito(_conta);
            _emprestimo = new Emprestimo(_conta);
            _pagamento = new Pagamento(_conta);
            _saque = new Saque(_conta);
        }

        public void Sacar(decimal valor)
        {
            _saque.Realizar(valor);
        }

        public void Depositar(decimal valor)
        {
            _deposito.Realizar(valor);
        }

        public void ObterSaldo()
        {
            Console.WriteLine($"Seu saldo é de {_conta.ObterSaldo()}");
        }
    }
}
