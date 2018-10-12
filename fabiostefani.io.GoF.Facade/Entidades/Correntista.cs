namespace fabiostefani.io.GoF.Facade.Entidades
{
    public interface ICorrentista
    {

    }
    public class Correntista : ICorrentista
    {
        public int Id { get; set; }
        public string Agencia { get; set; }
        public string ContaCorrente { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
    }
}
