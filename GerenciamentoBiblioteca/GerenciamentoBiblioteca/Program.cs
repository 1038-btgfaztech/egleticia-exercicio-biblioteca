using GerenciamentoBiblioteca;

Biblioteca biblioteca = new();

ItemBiblioteca midiaDigital = new MidiaDigital("O Dilema das Redes Sociais", "Netflix", new DateTime(2023, 5, 8), 94);
ItemBiblioteca livro = new Livro("Viagem ao Centro da Terra", "Julio Verne", new DateTime(1836, 5, 24), 256);
ItemBiblioteca revista = new Revista("Recreio - N 198", "Abril", new DateTime(2009, 10, 11), 45);

biblioteca.AdicionarItemColecao(midiaDigital);
biblioteca.AdicionarItemColecao(livro);
biblioteca.AdicionarItemColecao(revista);


biblioteca.EmprestarItemBiblioteca(midiaDigital);
biblioteca.DevolverItemBiblioteca(midiaDigital);

biblioteca.EmprestarItemBiblioteca(livro);
biblioteca.DevolverItemBiblioteca(livro);

biblioteca.EmprestarItemBiblioteca(revista);
biblioteca.DevolverItemBiblioteca(revista);