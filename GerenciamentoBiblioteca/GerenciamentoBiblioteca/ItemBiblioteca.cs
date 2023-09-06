namespace GerenciamentoBiblioteca
{
    public abstract class ItemBiblioteca
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public DateTime AnoPublicacao { get; set; }
        public int DuracaoPaginasMinutos { get; set; }

        public ItemBiblioteca(string titulo, string autor, DateTime anoPublicacao, int duracaoPaginasMinutos)
        {
            Titulo = titulo;
            Autor = autor;
            AnoPublicacao = anoPublicacao;
            DuracaoPaginasMinutos = duracaoPaginasMinutos;
        }
    }
}
