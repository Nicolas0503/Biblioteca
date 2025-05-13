namespace Biblioteca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            Pessoa pessoa = new Pessoa();
            pessoa.ShowDialog();

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Exemplar exemplar = new Exemplar();
            exemplar.ShowDialog();
        }
    }
}
