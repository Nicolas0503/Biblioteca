using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Ebook : LivroClasse
    {
        public string Formato { get; set; }
        public decimal Tamanho { get; set; }
        public string Url { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()} | Formato: {Formato} | Tamanho: {Tamanho}MB | Url: {Url}";
        }
    }
}
