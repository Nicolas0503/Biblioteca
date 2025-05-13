using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;

namespace Biblioteca
{
    public class LeitorClasse : PessoaClasse
    {
        public List<Exemplar> ExemplaresLeitor { get; set; } = new();

        public override void ListaLeitor(LeitorClasse leitor)
        {
            Console.WriteLine($"Leitor: {leitor.Nome}");
        }

        public override void EditaLeitor(LeitorClasse leitor)
        {
            // Exemplo: editar o nome
            leitor.Nome = "Novo Nome";
        }

        public override void AdicionaExemplarLeitor(Exemplar exemplar, LeitorClasse leitor)
        {
            leitor.ExemplaresLeitor.Add(exemplar);
        }

        public override void RemoveExemplarLeitor(Exemplar exemplar, LeitorClasse leitor)
        {
            leitor.ExemplaresLeitor.Remove(exemplar);
        }

        public override void EditaExemplarLeitor(Exemplar exemplar, LeitorClasse leitor)
        {
            // Exemplo: editar alguma propriedade do exemplar
            // (depende da implementação da classe Exemplar)
        }

        public override void ListaExemplarLeitor(Exemplar exemplar, LeitorClasse leitor)
        {
            foreach (var ex in leitor.ExemplaresLeitor)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
