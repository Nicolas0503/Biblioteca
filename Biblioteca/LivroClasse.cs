using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class LivroClasse : ExemplarClasse
    {
        public int Paginas { get; set; }
        public string Autor { get; set; }
        public string TipoCapa { get; set; }
        public string ISBN { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()} | Páginas: {Paginas} | Capa: {TipoCapa} | ISBN: {ISBN}";
        }
    }
}
//Nícolas Bastos
