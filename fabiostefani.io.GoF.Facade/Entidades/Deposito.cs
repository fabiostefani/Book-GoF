namespace fabiostefani.io.GoF.Facade.Entidades
{
    public interface IDeposito
    {
        void Realizar(decimal valor);
    }

    public class Deposito : IDeposito
    {
        private IConta conta;
        public Deposito(IConta conta)
        {
            this.conta = conta;
        }

        public void Realizar(decimal valor)
        {
            this.conta.Creditar(valor);
        }
    }
}
