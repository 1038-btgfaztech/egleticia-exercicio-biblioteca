namespace GerenciamentoBiblioteca
{
    public class MidiaDigital : ItemBiblioteca, IPodeSerEmprestado
    {
        public MidiaDigital(string titulo, string autor, DateTime anoPublicacao, int duracaoPaginasMinutos) : base(titulo, autor, anoPublicacao, duracaoPaginasMinutos)
        {
        }

        public void CalculaDataDevolucao()
        {
            Console.WriteLine($"A data máxima de devolução da Mídia Digital: {Titulo}, é {DateTime.Now.AddDays(15)}");
        }

        public void RealizaEmprestimo()
        {
            Console.WriteLine($"O Empréstimo da Mídia Digital: {Titulo}, foi realizado na data: {DateTime.Now}");
        }

        public void VerificaMulta(int quantidadeDiasEmprestimoReal)
        {
            if(quantidadeDiasEmprestimoReal > 15)
                Console.WriteLine($"Seu empréstimo da Mídia Digital: {Titulo}, gerou multa!");
        }

        public void RealizaDevolucao()
        {
            Console.WriteLine($"A Devolução da Mídia Digital: {Titulo}, foi realizado na data: {DateTime.Now}");
        }

    }
}
