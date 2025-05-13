using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class RevistaClasse : ExemplarClasse
    {
        public int Edicao { get; set; }
        public int Paginas { get; set; }
        public RevistaClasse(string titulo,
        string subTitulo,
        string escritor,
        string editora,
        int anoPublicacao,
        string genero,
        int status,
        int edicao,
        int paginas) : base(titulo, subTitulo, escritor, editora, anoPublicacao, genero, status)

        {
            Edicao = edicao;
            Paginas = paginas;
        }
        public override string ToString()
        {
            return "";
        }
    }
}
//Nicolas Bastos