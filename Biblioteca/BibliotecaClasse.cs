using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

﻿using System.Collections.Generic;

namespace Biblioteca
{
    public class BibliotecaClasse
    {
         List<LivroClasse> Livros { get; set; } = new();
         List<Exemplar> Exemplares { get; set; } = new();
         List<LeitorClasse> Leitores { get; set; } = new();
         List<FuncionarioClasse> Funcionarios { get; set; } = new();

        //public void AdicionarLivro(LivroClasse livro)
        //{
        //    Livros.Add(livro);
        //}

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
    //    public LivroClasse BuscarLivroPorISBN(string isbn)
    //{
    //        return Livros.Find(l => l.ISBN == isbn);
    //    }

        
    }
}
//Nícolas Bastos

﻿
