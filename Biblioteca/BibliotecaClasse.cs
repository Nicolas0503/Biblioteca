
﻿using System.Collections.Generic;

namespace Biblioteca
{
    public class BibliotecaClasse
    {
        public List<LivroClasse> Livros { get; set; } = new();
        public List<Exemplar> Exemplares { get; set; } = new();
        public List<LeitorClasse> Leitores { get; set; } = new();
        public List<FuncionarioClasse> Funcionarios { get; set; } = new();

        public void AdicionarLivro(LivroClasse livro)
        {
            Livros.Add(livro);
        }

        public void AdicionarExemplar(Exemplar exemplar)
        {
            Exemplares.Add(exemplar);
        }

        public void AdicionarLeitor(LeitorClasse leitor)
        {
            Leitores.Add(leitor);
        }

        public void AdicionarFuncionario(FuncionarioClasse funcionario)
        {
            Funcionarios.Add(funcionario);
        }

        // Exemplo de busca de livro por ISBN
        public LivroClasse BuscarLivroPorISBN(string isbn)
        {
            return Livros.Find(l => l.ISBN == isbn);
        }

        
    }
}
//Nícolas Bastos

﻿
