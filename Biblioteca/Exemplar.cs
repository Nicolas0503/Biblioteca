using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Biblioteca
{
    public partial class Exemplar : Form
    {


        // variável com escopo de classe
        List<ExemplarClasse> exemplares;
        ExemplarClasse exemplar;
        // incluído parâmetro para receber a lista de exemplares
        public Exemplar(List<ExemplarClasse> exemplares)
        {
            InitializeComponent();
            // atribui a lista de exemplares recebida à variável com escopo de classe
            this.exemplares = exemplares;
            

            listBoxTipo.DataSource = Enum.GetValues(typeof(EnumGenericoTipo));
            listBoxTipo.SelectedIndex = 0;
            comboBoxStatus.DataSource = Enum.GetValues(typeof(EnumExemplarStatus));
            comboBoxStatus.SelectedIndex = 0;
        }
        public Exemplar(List<ExemplarClasse> exemplares, ExemplarClasse exemplar)
        {
            InitializeComponent();
            // atribui a lista de exemplares recebida à variável com escopo de classe
            this.exemplares = exemplares;
            this.exemplar = exemplar;
            checkBoxEbook.Enabled = false;
            // carrega os valores do Enum para o combobox/listbox
            comboBoxStatus.DataSource = Enum.GetValues(typeof(EnumExemplarStatus));
            comboBoxStatus.SelectedIndex = 0;
            listBoxTipo.DataSource = Enum.GetValues(typeof(EnumGenericoTipo));
            listBoxTipo.SelectedIndex = 0;
            // verifica o tipo do exemplar, e carrega os valores nos campos da tela
            if (exemplar is LivroClasse || exemplar is EbookClasse)
            {
                // livro e ebook
                textBoxTitulo.Text = exemplar.Titulo;
                textBoxSubTitulo.Text = exemplar.SubTitulo;
                textBoxEscritor.Text = exemplar.Escritor;
                textBoxEditora.Text = exemplar.Editora;
                numericUpDownAnoPublicacao.Value = exemplar.AnoPublicacao;
                comboBoxGenero.Text = exemplar.Genero;
                comboBoxStatus.Text = "" + (EnumExemplarStatus)Enum.Parse(typeof(EnumExemplarStatus), exemplar.Status.ToString());
                numericUpDownPaginasLivro.Value = ((LivroClasse)exemplar).Paginas;
                comboBoxTipoCapa.Text = ((LivroClasse)exemplar).TipoCapa;
                textBoxIsbn.Text = ((LivroClasse)exemplar).Isbn;
                checkBoxEbook.Checked = false;
                if (exemplar is EbookClasse)
                {
                    checkBoxEbook.Checked = true;
                    comboBoxFormato.Text = ((EbookClasse)exemplar).Formato;
                    numericUpDownTamanho.Value = ((EbookClasse)exemplar).Tamanho;
                    textBoxUrl.Text = ((EbookClasse)exemplar).Url;
                }
            }
            else if (exemplar is RevistaClasse revista)
            {
                numericUpDownEdicaoRevista.Value = revista.Edicao;
                numericUpDownPaginasRevista.Value = revista.Paginas;
            }
            else if (exemplar is HqClasse hq)
            {
                numericUpDown6.Value = hq.Edicao;
                textBoxIlustrador.Text = hq.Ilustrador;
            }
            else if (exemplar is GenericoClasse)
            {
                listBoxTipo.Text = "" + (EnumGenericoTipo)Enum.Parse(typeof(EnumGenericoTipo), ((GenericoClasse)exemplar).Tipo.ToString());
            }
        }


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            panel1.Visible = checkBoxEbook.Checked;
            numericUpDownTamanho.Visible = checkBoxEbook.Checked;
            textBoxUrl.Visible = checkBoxEbook.Checked;
            comboBoxFormato.Visible = checkBoxEbook.Checked;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void Exemplar_Load(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            // leitura dos valores dos campos
            string auxTitulo = textBoxTitulo.Text;
            string auxSubTitulo = textBoxSubTitulo.Text;
            string auxEscritor = textBoxEscritor.Text;
            string auxEditora = textBoxEditora.Text;
            int auxAnoPublicacao = Convert.ToInt32(numericUpDownAnoPublicacao.Value);
            string auxGenero = comboBoxGenero.Text;
            int auxStatus = (int)(EnumExemplarStatus)Enum.Parse(typeof(EnumExemplarStatus), comboBoxStatus.Text);
            if (tabControlExemplar.SelectedIndex == 0)
            {
                // livro e ebook
                // leitura dos valores dos campos
                int auxPaginas = Convert.ToInt32(numericUpDownPaginasLivro.Value);
                string auxTipoCapa = comboBoxTipoCapa.Text;
                string auxIsbn = textBoxIsbn.Text;
                if (!checkBoxEbook.Checked)
                {
                    // livro
                    // cria o objeto e já adiciona no List
                    exemplares.Add(new LivroClasse(auxTitulo, auxSubTitulo, auxEscritor, auxEditora, auxAnoPublicacao, auxGenero, auxStatus, auxPaginas, auxTipoCapa, auxIsbn));
                }
                else
                {
                    // ebook
                    // leitura dos valores dos campos
                    string auxFormato = comboBoxFormato.Text;
                    decimal auxTamanho = numericUpDownTamanho.Value;
                    string auxUrl = textBoxUrl.Text;
                    // cria o objeto e já adiciona no List
                    exemplares.Add(new EbookClasse(auxTitulo, auxSubTitulo, auxEscritor, auxEditora, auxAnoPublicacao, auxGenero, auxStatus, auxPaginas, auxTipoCapa, auxIsbn, auxFormato, auxTamanho, auxUrl));
                }
            }
            else if (tabControlExemplar.SelectedIndex == 1)
            {
                // revista
                // leitura dos valores dos campos
                int auxEdicaoRevista = Convert.ToInt32(numericUpDownEdicaoRevista.Value);
                int auxPaginasRevista = Convert.ToInt32(numericUpDownPaginasRevista.Value);
                // cria o objeto e já adiciona no List
                exemplares.Add(new RevistaClasse(auxTitulo, auxSubTitulo, auxEscritor, auxEditora, auxAnoPublicacao, auxGenero, auxStatus, auxEdicaoRevista, auxPaginasRevista));
            }
            else if (tabControlExemplar.SelectedIndex == 2)
            {
                // hq
                // leitura dos valores dos campos
                int auxEdicaoHq = Convert.ToInt32(numericUpDown6.Value);
                string auxIlustrador = textBoxIlustrador.Text;
                // cria o objeto e já adiciona no List
                exemplares.Add(new HqClasse(auxTitulo, auxSubTitulo, auxEscritor, auxEditora, auxAnoPublicacao, auxGenero, auxStatus, auxEdicaoHq, auxIlustrador));
            }
            else if (tabControlExemplar.SelectedIndex == 3)
            {
                // generico
                // leitura dos valores dos campos
                int auxTipo = (int)(EnumGenericoTipo)Enum.Parse(typeof(EnumGenericoTipo), listBoxTipo.Text);
                // cria o objeto e já adiciona no List
                exemplares.Add(new GenericoClasse(auxTitulo, auxSubTitulo, auxEscritor, auxEditora, auxAnoPublicacao, auxGenero, auxStatus, auxTipo));
            }

            MessageBox.Show("Exemplar cadastrado com sucesso!");
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {

            // leitura dos valores dos campos
            exemplar.Titulo = textBoxTitulo.Text;
            exemplar.SubTitulo = textBoxSubTitulo.Text;
            exemplar.Escritor = textBoxEscritor.Text;
            exemplar.Editora = textBoxEditora.Text;
            exemplar.AnoPublicacao = Convert.ToInt32(numericUpDownAnoPublicacao.Value);
            exemplar.Genero = comboBoxGenero.Text;
            exemplar.Status = (int)(EnumExemplarStatus)Enum.Parse(typeof(EnumExemplarStatus), comboBoxStatus.Text);
            if (exemplar is LivroClasse livro)
            {
                livro.Paginas = Convert.ToInt32(numericUpDownPaginasLivro.Value);
                livro.TipoCapa = comboBoxTipoCapa.Text;
                livro.Isbn = textBoxIsbn.Text;
            }
            else if (exemplar is EbookClasse ebook)
            {
                ebook.Paginas = Convert.ToInt32(numericUpDownPaginasLivro.Value);
                ebook.TipoCapa = comboBoxTipoCapa.Text;
                ebook.Isbn = textBoxIsbn.Text;
                ebook.Formato = comboBoxFormato.Text;
                ebook.Tamanho = numericUpDownTamanho.Value;
                ebook.Url = textBoxUrl.Text;
            }
            else if (exemplar is RevistaClasse revista)
            {
                revista.Edicao = Convert.ToInt32(numericUpDownEdicaoRevista.Value);
                revista.Paginas = Convert.ToInt32(numericUpDownPaginasRevista.Value);
            }
            else if (exemplar is HqClasse hq)
            {
                hq.Edicao = Convert.ToInt32(numericUpDown6.Value);
                hq.Ilustrador = textBoxIlustrador.Text;
            }
            else if (exemplar is GenericoClasse generico)
            {
                generico.Tipo = (int)(EnumGenericoTipo)Enum.Parse(typeof(EnumGenericoTipo), listBoxTipo.Text);
            }
            MessageBox.Show("Exemplar editado com sucesso!");
            Close();

        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            exemplares.Remove(exemplar);
            MessageBox.Show("Exemplar excluido com sucesso!");
            Close();
        }
    }
}
//Nicolas Bastos