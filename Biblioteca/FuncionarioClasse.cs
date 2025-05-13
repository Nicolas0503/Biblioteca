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

        public void NovoLeitor(LeitorClasse leitor) { }
        public void ExcluiLeitor(LeitorClasse leitor) { }
        public void EditaFuncionario(FuncionarioClasse funcionario) { }
        public void ExcluiFuncionario(FuncionarioClasse funcionario) { }
        public void NovoExemplar(Exemplar exemplar) { }
        public void ListaFuncionario() { }
        public void ExcluiExemplar(Exemplar exemplar) { }
        public void EditaExemplar(Exemplar exemplar) { }
        public void ListaExemplar() { }

        public override string ToString()
        {
            return $"{Nome} - {Funcao}";
        }

        public override void ListaLeitor(LeitorClasse leitor) { }
        public override void EditaLeitor(LeitorClasse leitor) { }
        public override void AdicionaExemplarLeitor(Exemplar exemplar, LeitorClasse leitor) { }
        public override void RemoveExemplarLeitor(Exemplar exemplar, LeitorClasse leitor) { }
        public override void EditaExemplarLeitor(Exemplar exemplar, LeitorClasse leitor) { }
        public override void ListaExemplarLeitor(Exemplar exemplar, LeitorClasse leitor) { }
    }
}
