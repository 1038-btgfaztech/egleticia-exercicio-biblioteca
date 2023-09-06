namespace GerenciamentoBiblioteca
{
    public class Revista : ItemBiblioteca, IPodeSerEmprestado
    {
        public Revista(string titulo, string autor, DateTime anoPublicacao, int duracaoPaginasMinutos) : base(titulo, autor, anoPublicacao, duracaoPaginasMinutos)
        {
        }

        public void CalculaDataDevolucao()
        {
            Console.WriteLine($"A data máxima de devolução da Revista: {Titulo}, é {DateTime.Now.AddDays(10)}");
        }

        public void RealizaEmprestimo()
        {
            Console.WriteLine($"O Empréstimo da Revista: {Titulo}, foi realizado na data: {DateTime.Now}");
        }

        public void VerificaMulta(int quantidadeDiasEmprestimoReal)
        {
            if (quantidadeDiasEmprestimoReal > 10)
                Console.WriteLine($"Seu empréstimo da Revista: {Titulo}, gerou multa!");
        }

        public void RealizaDevolucao()
        {
            Console.WriteLine($"A Devolução da Revista: {Titulo}, foi realizado na data: {DateTime.Now}");
        }
    }
}
