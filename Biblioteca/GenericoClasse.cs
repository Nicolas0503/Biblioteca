using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Generico : ExemplarClasse
    {
        public int Tipo { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()} | Tipo: {Tipo}";
        }
    }
}
//Nícolas Bastos