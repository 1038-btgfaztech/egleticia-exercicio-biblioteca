namespace GerenciamentoBiblioteca
{
    public class Livro : ItemBiblioteca, IPodeSerEmprestado
    {
        public Livro(string titulo, string autor, DateTime anoPublicacao, int duracaoPaginasMinutos) : base(titulo, autor, anoPublicacao, duracaoPaginasMinutos)
        {
        }

        public void CalculaDataDevolucao()
        {
            Console.WriteLine($"A data máxima de devolução do Livro: {Titulo}, é {DateTime.Now.AddDays(20)}");
        }

        public void RealizaEmprestimo()
        {
            Console.WriteLine($"O Empréstimo do Livro: {Titulo}, foi realizado na data: {DateTime.Now}");
        }

        public void VerificaMulta(int quantidadeDiasEmprestimoReal)
        {
            if (quantidadeDiasEmprestimoReal > 20)
                Console.WriteLine($"Seu empréstimo do Livro: {Titulo}, gerou multa!");
        }

        public void RealizaDevolucao()
        {
            Console.WriteLine($"A Devolução do Livro: {Titulo}, foi realizado na data: {DateTime.Now}");
        }
    }
}
