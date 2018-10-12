using System;

namespace fabiostefani.io.GoF.Facade.Entidades
{
    public interface IConta
    {
        void Creditar(decimal valor);
        void Debitar(decimal valor);
        decimal ObterSaldo();
    }

    public class Conta : IConta
    {
        private decimal saldo;
        private ICorrentista correntista;
        public Conta(ICorrentista correntista)
        {
            this.correntista = correntista;
            saldo = 0;
        }

        public void Creditar(decimal valor)
        {

            saldo = saldo + valor;
            Console.WriteLine("Credito realizado com sucesso.");
        }

        public void Debitar(decimal valor)
        {
            saldo = saldo - valor;
            Console.WriteLine("Débito realizado com sucesso.");
        }

        public decimal ObterSaldo()
        {
            return saldo;
        }
    }
}
