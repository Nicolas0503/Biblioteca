using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class Pessoa : Form
    {
        List<FuncionarioClasse> funcionarios;
        List<LeitorClasse> leitores;

        public Pessoa(List<FuncionarioClasse> funcionarios, List<LeitorClasse> leitores)
        {
            InitializeComponent();
            // atribui a lista de exemplares recebida à variável com escopo de classe
            this.funcionarios = funcionarios;
            this.leitores = leitores;

            // carrega os valores do Enum para o combobox
            comboBoxCargo.DataSource = Enum.GetValues(typeof(EnumFuncionarioCargo));
            comboBoxCargo.SelectedIndex = 0;
        }

        private void gd(object sender, EventArgs e)
        {

        }

        private void Nascimento_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Pessoa_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxCargo.DataSource = Enum.GetValues(typeof(EnumFuncionarioCargo));
            comboBoxCargo.SelectedIndex = 0;
        }

        private void Leitor_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // leitura dos valores dos campos
            string auxNome = textBoxNome.Text;
            DateTime auxData = dateTimePickerNascimento.Value;
            string auxCpf = maskedTextBoxCpf.Text;
            string auxEmail = maskedTextBoxEmail.Text;
            string auxTelefone = maskedTextBoxTelefone.Text;
            if (tabControlPessoa.SelectedIndex == 0)
            {
                // leitura dos valores dos campos
                string auxTipoLeitor = listBoxTipoLeitor.SelectedItem.ToString();
                // cria o objeto leitor
                var leitor = new LeitorClasse(auxNome, auxData, auxCpf, auxEmail, auxTelefone, auxTipoLeitor);
                // adicionar no list
                leitores.Add(leitor);
            }
            else
            {
                // leitura dos valores dos campos
                int auxCargo = (int)(EnumFuncionarioCargo)Enum.Parse(typeof(EnumFuncionarioCargo), comboBoxCargo.Text);
                decimal auxSalario = numericUpDownSalario.Value;
                int auxCargaHoraria = Convert.ToInt32(numericUpDownCargaHoraria.Value);
                string auxFuncao = textBoxFuncao.Text;
                // cria o objeto funcionário e já adiciona diretamente
                funcionarios.Add(new FuncionarioClasse(auxNome, auxData, auxCpf, auxEmail, auxTelefone, auxCargo, auxSalario, auxCargaHoraria, auxFuncao));
            }
            MessageBox.Show("Pessoa cadastrada com sucesso!");
            Close();



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
//Nicolas Bastos
