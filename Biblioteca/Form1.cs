using System.Numerics;

namespace Biblioteca
{
    public partial class Form1 : Form
    {
        public List<FuncionarioClasse> funcionarios;
        public List<LeitorClasse> leitores;
        public List<ExemplarClasse> exemplares;
        public Form1()
        {
            InitializeComponent();
            funcionarios = new List<FuncionarioClasse>();
            leitores = new List<LeitorClasse>();
            exemplares = new List<ExemplarClasse>();
            CargaInicial();
            AtualizarDataGridView();

        }
        private void CargaInicial()
        {
            leitores.Add(new LeitorClasse("leitor 1", DateTime.Today, "cpf1", "email1", "tel1", "tipo1"));
            leitores.Add(new LeitorClasse("leitor 2", DateTime.Today, "cpf2", "email2", "tel2", "tipo2"));
            leitores.Add(new LeitorClasse("leitor 3", DateTime.Today, "cpf3", "email3", "tel3", "tipo3"));
            leitores.Add(new LeitorClasse("leitor 4", DateTime.Today, "cpf3", "email4", "tel4", "tipo4"));
            leitores.Add(new LeitorClasse("leitor 5", DateTime.Today, "cpf3", "email5", "tel5", "tipo5"));
            funcionarios.Add(new FuncionarioClasse("funcionário 1", DateTime.Today, "cpf1", "email1", "tel1", 0, 9999.99M, 8, "fun1"));
            funcionarios.Add(new FuncionarioClasse("funcionário 2", DateTime.Today, "cpf2", "email2", "tel2", 1, 3333.33M, 8, "fun1"));
            funcionarios.Add(new FuncionarioClasse("funcionário 3", DateTime.Today, "cpf3", "email3", "tel3", 3, 1024.00M, 6, "fun1"));
            funcionarios.Add(new FuncionarioClasse("funcionário 4", DateTime.Today, "cpf3", "email4", "tel4", 3, 1024.00M, 6, "fun1"));
            funcionarios.Add(new FuncionarioClasse("funcionário 5", DateTime.Today, "cpf3", "email5", "tel5", 2, 2222.22M, 8, "fun1"));
            exemplares.Add(new LivroClasse("livro 1", "subtitulo1", "escritor1", "editora1", 2021, "genero1", 1, 100, "tipoCapa1", "isbn1"));
            exemplares.Add(new LivroClasse("livro 2", "subtitulo2", "escritor2", "editora2", 2021, "genero2", 2, 112, "tipoCapa2", "isbn2"));
            exemplares.Add(new LivroClasse("livro 3", "subtitulo3", "escritor3", "editora3", 2021, "genero3", 3, 132, "tipoCapa3", "isbn3"));
            exemplares.Add(new LivroClasse("livro 4", "subtitulo4", "escritor4", "editora4", 2021, "genero4", 4, 234, "tipoCapa4", "isbn4"));
            exemplares.Add(new LivroClasse("livro 5", "subtitulo5", "escritor5", "editora5", 2021, "genero5", 5, 432, "tipoCapa5", "isbn5"));
            exemplares.Add(new EbookClasse("ebook 1", "subtitulo1", "escritor1", "editora1", 2021, "genero1", 1, 123, "tipoCapa1", "isbn1", "formato1", 1, "url1"));
            exemplares.Add(new EbookClasse("ebook 2", "subtitulo2", "escritor2", "editora2", 2021, "genero2", 2, 321, "tipoCapa2", "isbn2", "formato2", 1, "url2"));
            exemplares.Add(new EbookClasse("ebook 3", "subtitulo3", "escritor3", "editora3", 2021, "genero3", 3, 987, "tipoCapa3", "isbn3", "formato3", 1, "url3"));
            exemplares.Add(new EbookClasse("ebook 4", "subtitulo4", "escritor4", "editora4", 2021, "genero4", 4, 31, "tipoCapa4", "isbn4", "formato4", 1, "url4"));
            exemplares.Add(new EbookClasse("ebook 5", "subtitulo5", "escritor5", "editora5", 2021, "genero5", 5, 909, "tipoCapa5", "isbn5", "formato5", 1, "url5"));
            exemplares.Add(new RevistaClasse("revista 1", "subtitulo1", "escritor1", "editora1", 2021, "genero1", 1, 324, 1));
            exemplares.Add(new RevistaClasse("revista 2", "subtitulo2", "escritor2", "editora2", 2021, "genero2", 2, 123, 1));
            exemplares.Add(new RevistaClasse("revista 3", "subtitulo3", "escritor3", "editora3", 2021, "genero3", 3, 654, 1));
            exemplares.Add(new RevistaClasse("revista 4", "subtitulo4", "escritor4", "editora4", 2021, "genero4", 4, 764, 1));
            exemplares.Add(new RevistaClasse("revista 5", "subtitulo5", "escritor5", "editora5", 2021, "genero5", 5, 234, 1));
            exemplares.Add(new HqClasse("hq 1", "subtitulo1", "escritor1", "editora1", 2021, "genero1", 1, 432, "ilustrador1"));
            exemplares.Add(new HqClasse("hq 2", "subtitulo2", "escritor2", "editora2", 2021, "genero2", 2, 542, "ilustrador2"));
            exemplares.Add(new HqClasse("hq 3", "subtitulo3", "escritor3", "editora3", 2021, "genero3", 3, 298, "ilustrador3"));
            exemplares.Add(new HqClasse("hq 4", "subtitulo4", "escritor4", "editora4", 2021, "genero4", 4, 342, "ilustrador4"));
            exemplares.Add(new HqClasse("hq 5", "subtitulo5", "escritor5", "editora5", 2021, "genero5", 5, 98, "ilustrador5"));
            exemplares.Add(new GenericoClasse("genérico 1", "subtitulo1", "escritor1", "editora1", 2021, "genero1", 1, 0));
            exemplares.Add(new GenericoClasse("genérico 2", "subtitulo2", "escritor2", "editora2", 2021, "genero2", 2, 1));
            exemplares.Add(new GenericoClasse("genérico 3", "subtitulo3", "escritor3", "editora3", 2021, "genero3", 3, 2));
            exemplares.Add(new GenericoClasse("genérico 4", "subtitulo4", "escritor4", "editora4", 2021, "genero4", 4, 3));
            exemplares.Add(new GenericoClasse("genérico 5", "subtitulo5", "escritor5", "editora5", 2021, "genero5", 5, 4));
        }
        private void AtualizarDataGridView()
        {
            // listar funcionarios no datagridview
            dataGridViewFuncionario.DataSource = null;
            dataGridViewFuncionario.DataSource = funcionarios;
            // listar leitores no datagridview
            dataGridViewLeitores.DataSource = null;
            dataGridViewLeitores.DataSource = leitores;
            // listar exemplares no datagridview
            dataGridViewExemplares.DataSource = null;
            dataGridViewExemplares.DataSource = exemplares;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var aux = new Pessoa(funcionarios, leitores);
            aux.StartPosition = FormStartPosition.CenterParent;
            aux.ShowDialog();
            AtualizarDataGridView();

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            var aux = new Exemplar(exemplares);
            aux.StartPosition = FormStartPosition.CenterParent;
            aux.ShowDialog();
            AtualizarDataGridView();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
//Nicolas Bastos