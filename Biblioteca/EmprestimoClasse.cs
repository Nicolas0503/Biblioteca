using System;
using System.Numerics;

namespace Biblioteca
{
    public class EmprestimoClasse
    {
        public LeitorClasse Origem { get; set; }
        public LeitorClasse Destino { get; set; }
        public Exemplar MeuExemplar { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime DataDevolucao { get; set; }
    }
}
//Nícolas Bastos