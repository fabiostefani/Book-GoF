namespace fabiostefani.io.GoF.Adapter.Exemplo_02
{
    public interface ITomada<P>
    {
        void Conecta(P plug);
        string GetNomeRede();
    }
}
