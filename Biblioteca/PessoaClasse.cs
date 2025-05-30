﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


namespace Biblioteca
{
    public abstract class PessoaClasse
    {
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
    public PessoaClasse(string nome,
    DateTime nascimento,
    string cpf,
    string email,
    string telefone)

    {
        Nome = nome;
        Nascimento = nascimento;
        Cpf = cpf;
        Email = email;
        Telefone = telefone;
    }
        public abstract void AdicionaExemplarLeitor(Exemplar exemplar, LeitorClasse leitor);
        public abstract void RemoveExemplarLeitor(Exemplar exemplar, LeitorClasse leitor);
        public abstract void EditaExemplarLeitor(Exemplar exemplar, LeitorClasse leitor);
        public abstract void ListaExemplarLeitor(Exemplar exemplar, LeitorClasse leitor);
    }
}

//Nicolas Bastos