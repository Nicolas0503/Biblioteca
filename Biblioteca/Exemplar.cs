using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
