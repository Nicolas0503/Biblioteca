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
        public Exemplar()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            panel1.Visible = checkBox1.Checked;
            numericUpDown3.Visible = checkBox1.Checked;
            textBox7.Visible = checkBox1.Checked;
            listBox1.Visible = checkBox1.Checked;

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
            comboBox3.DataSource = Enum.GetValues(typeof(EnumGenericoTipo));
            comboBox3.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.DataSource = Enum.GetValues(typeof(EnumExemplarStatus));
            comboBox1.SelectedIndex = 0;
        }

        private void Exemplar_Load_1(object sender, EventArgs e)
        {

        }
    }
}
