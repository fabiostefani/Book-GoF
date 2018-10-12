namespace fabiostefani.io.GoF.Facade.Entidades
{
    public interface IEmprestimo
    {
        void Realizar(decimal valor);
    }

    public class Emprestimo : IEmprestimo
    {

        private IConta conta;
        public Emprestimo(IConta conta)
        {
            this.conta = conta;
        }

        public void Realizar(decimal valor)
        {
            this.conta.Creditar(valor);
        }
    }
}
