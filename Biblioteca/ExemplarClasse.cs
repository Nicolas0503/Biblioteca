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
        public ExemplarClasse(string titulo,
        string subTitulo,
        string escritor,
        string editora,
        int anoPublicacao,
        string genero,
        int status)

        public override string ToString()
        {
            Titulo = titulo;
            SubTitulo = subTitulo;
            Escritor = escritor;
            Editora = editora;
            AnoPublicacao = anoPublicacao;
            Genero = genero;
            Status = status;
           
        }
    }
}
//Nicolas Bastos