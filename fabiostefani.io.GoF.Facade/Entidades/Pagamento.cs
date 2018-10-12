namespace fabiostefani.io.GoF.Facade.Entidades
{
    public interface IPagamento
    {
        void Realizar(decimal valor);
    }
    public class Pagamento : IPagamento
    {
        private IConta conta;
        public Pagamento(IConta conta)
        {
            this.conta = conta;
        }

        public void Realizar(decimal valor)
        {
            this.conta.Debitar(valor);
        }
    }
}
