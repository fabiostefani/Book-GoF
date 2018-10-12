namespace fabiostefani.io.GoF.Facade.Entidades
{
    public interface ISaque
    {
        void Realizar(decimal valor);
    }
    public class Saque : ISaque
    {
        private IConta conta;
        public Saque(IConta conta)
        {
            this.conta = conta;
        }

        public void Realizar(decimal valor)
        {
            this.conta.Debitar(valor);
        }
    }
}
