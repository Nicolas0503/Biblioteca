using System;
using System.Collections.Generic;
using System.Linq;
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

        public abstract void ListaLeitor(LeitorClasse leitor);
        public abstract void EditaLeitor(LeitorClasse leitor);
        public abstract void AdicionaExemplarLeitor(Exemplar exemplar, LeitorClasse leitor);
        public abstract void RemoveExemplarLeitor(Exemplar exemplar, LeitorClasse leitor);
        public abstract void EditaExemplarLeitor(Exemplar exemplar, LeitorClasse leitor);
        public abstract void ListaExemplarLeitor(Exemplar exemplar, LeitorClasse leitor);
    }
}

//Nícolas Bastos