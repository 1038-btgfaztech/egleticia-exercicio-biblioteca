namespace GerenciamentoBiblioteca
{
    public class Biblioteca
    {
        public List<ItemBiblioteca> ItensBiblioteca { get; set; } = new();

        public void AdicionarItemColecao(ItemBiblioteca item)
        {
            ItensBiblioteca.Add(item);
        }

        public void EmprestarItemBiblioteca(ItemBiblioteca item)
        {
            if (item is IPodeSerEmprestado itemEmprestavel)
                itemEmprestavel.RealizaEmprestimo();

            else
                Console.WriteLine("Empréstimo não realizado.");
        }

        public void DevolverItemBiblioteca(ItemBiblioteca item)
        {
            if (item is IPodeSerEmprestado itemEmprestavel)
                itemEmprestavel.RealizaDevolucao();

            else
                Console.WriteLine("Devolução não realizado.");
        }


    }
}
