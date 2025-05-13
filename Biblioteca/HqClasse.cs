using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class HqClasse : ExemplarClasse
    {
        public int Edicao { get; set; }
        public string Ilustrador { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()} | Edição: {Edicao} | Ilustrador: {Ilustrador}";
        }
    }
}

