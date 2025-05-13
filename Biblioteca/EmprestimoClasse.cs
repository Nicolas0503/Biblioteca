using System;
using System.Numerics;

namespace Biblioteca
{
    public class Emprestimo
    {
        public LeitorClasse Origem { get; set; }
        public LeitorClasse Destino { get; set; }
        public ExemplarClasse Item { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime DataDevolucao { get; set; }
        public Emprestimo(LeitorClasse origem,
        LeitorClasse destino,
        ExemplarClasse item,
        DateTime dataEmprestimo,
        DateTime dataDevolucao)

        {
            Origem = origem;
            Destino = destino;
            Item = item;
            DataEmprestimo = dataEmprestimo;
            DataDevolucao = dataDevolucao;
        }
    }
}
//Nicolas Bastos