namespace Biblioteca
{
    // Classe abstrata base
    public abstract class ExemplarClasse
    {
        public string Titulo { get; set; }
        public string SubTitulo { get; set; }
        public string Escritor { get; set; }
        public string Editora { get; set; }
        public int AnoPublicacao { get; set; }
        public string Genero { get; set; }
        public int Status { get; set; }

        public override string ToString()
        {
            return $"{Titulo} - {Escritor} ({AnoPublicacao})";
        }
    }
}
//Nícolas Bastos