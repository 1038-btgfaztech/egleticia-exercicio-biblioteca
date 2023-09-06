namespace GerenciamentoBiblioteca
{
    public interface IPodeSerEmprestado
    {
        public void CalculaDataDevolucao();
        public void RealizaEmprestimo();
        public void VerificaMulta(int quantidadeDiasEmprestimoReal);
        public void RealizaDevolucao();
    }
}
