using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class LivroClasse : ExemplarClasse
    {
        public int Paginas { get; set; }
        public string TipoCapa { get; set; }
        public string Isbn { get; set; }
        public LivroClasse(string titulo,
        string subTitulo,
        string escritor,
        string editora,
        int anoPublicacao,
        string genero,
        int status,
        int paginas,
        string tipoCapa,
        string isbn) : base(titulo, subTitulo, escritor, editora, anoPublicacao, genero, status)

        {
            Paginas = paginas;
            TipoCapa = tipoCapa;
            Isbn = isbn;
        }
        public override string ToString()
        {
            return "";
        }
    }
}
//Nicolas Bastos