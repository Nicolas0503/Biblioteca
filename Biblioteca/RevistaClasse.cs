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

        public override string ToString()
        {
            return $"{base.ToString()} | Edição: {Edicao} | Páginas: {Paginas}";
        }
    }
}
//Nícolas Bastos