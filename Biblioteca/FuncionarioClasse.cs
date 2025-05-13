using System.Collections.Generic;
using System.Numerics;

namespace Biblioteca
{
    public class FuncionarioClasse : PessoaClasse
    {
        public int Cargo { get; set; }
        public decimal Salario { get; set; }
        public int CargaHoraria { get; set; }
        public string Funcao { get; set; }
        public FuncionarioClasse(string nome,
        DateTime nascimento,
        string cpf,
        string email,
        string telefone,
        int cargo,
        decimal salario,
        int cargaHoraria,
        string funcao) : base(nome, nascimento, cpf, email, telefone)

        {
            Cargo = cargo;
            Salario = salario;
            CargaHoraria = cargaHoraria;
            Funcao = funcao;
        }
        public void NovoLeitor(LeitorClasse leitor) { }
        public void ExcluiLeitor(LeitorClasse leitor) { }
        public void NovoFuncionario(FuncionarioClasse funcionario) { }
        public void EditaFuncionario(FuncionarioClasse funcionario) { }
        public void ExcluiFuncionario(FuncionarioClasse funcionario) { }
        public void ListaFuncionario(FuncionarioClasse funcionario) { }
        public void NovoExemplar(Exemplar exemplar) { }
        public void EditaExemplar(Exemplar exemplar) { }
        public void ExcluiExemplar(Exemplar exemplar) { }
        public void ListaExemplar(Exemplar exemplar) { }
        public override void AdicionaExemplarLeitor(Exemplar exemplar, LeitorClasse leitor) { }
        public override void RemoveExemplarLeitor(Exemplar exemplar, LeitorClasse leitor) { }
        public override void EditaExemplarLeitor(Exemplar exemplar, LeitorClasse leitor) { }
        public override void ListaExemplarLeitor(Exemplar exemplar, LeitorClasse leitor) { }
    }
}
//Nicolas Bastos