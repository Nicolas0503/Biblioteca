using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Numerics;

namespace Biblioteca
{
    public  class LeitorClasse : PessoaClasse
    {
        public List<Exemplar> ExemplaresLeitor { get; set; }
        public List<Emprestimo> EmprestimosLeitor { get; set; }
        public string Tipo { get; set; }
        public LeitorClasse(string nome,
        DateTime nascimento,
        string cpf,
        string email,
        string telefone,
        string tipo) : base(nome, nascimento, cpf, email, telefone)

        public override void ListaLeitor(LeitorClasse leitor)
        {
            Tipo = tipo;
            ExemplaresLeitor = new List<Exemplar>();
            EmprestimosLeitor = new List<Emprestimo>();
        }
        public bool EmprestaItem(Exemplar exemplar, LeitorClasse destino) { return false; }
        public bool DevolucaoItem(Exemplar exemplar, LeitorClasse destino) { return false; }
        public bool DoaExemplar(Exemplar exemplar, LeitorClasse destino) { return false; }
        public bool TrocaExemplar(Exemplar exemplarVai, LeitorClasse leitorVai, Exemplar exemplarVem) { return false; }
        public override void AdicionaExemplarLeitor(Exemplar exemplar, LeitorClasse leitor) { }
        public override void RemoveExemplarLeitor(Exemplar exemplar, LeitorClasse leitor) { }
        public override void EditaExemplarLeitor(Exemplar exemplar, LeitorClasse leitor) { }
        public override void ListaExemplarLeitor(Exemplar exemplar, LeitorClasse leitor) { }
    }
}
//Nicolas Bastos