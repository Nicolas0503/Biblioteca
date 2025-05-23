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
        FuncionarioClasse funcionario;
        LeitorClasse leitor;

        public Pessoa(List<FuncionarioClasse> funcionarios, List<LeitorClasse> leitores)
        {
            InitializeComponent();
            // atribui o objeto recebido à variável com escopo de classe
            this.leitores = leitores;
            this.funcionarios = funcionarios;
            // carrega os valores do Enum para o combobox
            comboBoxCargo.DataSource = Enum.GetValues(typeof(EnumFuncionarioCargo));
            comboBoxCargo.SelectedIndex = 0;
            //// carrega os valores do objeto recebido
            //textBoxNome.Text = funcionario.Nome;
            //dateTimePickerNascimento.Value = funcionario.Nascimento;
            //maskedTextBoxCpf.Text = funcionario.Cpf;
            //maskedTextBoxEmail.Text = funcionario.Email;
            //maskedTextBoxTelefone.Text = funcionario.Telefone;
            //comboBoxCargo.Text = "" + (EnumFuncionarioCargo)Enum.Parse(typeof(EnumFuncionarioCargo), funcionario.Cargo.ToString());
            //numericUpDownSalario.Value = funcionario.Salario;
            //numericUpDownCargaHoraria.Value = funcionario.CargaHoraria;
            //textBoxFuncao.Text = funcionario.Funcao;
            //tabControlPessoa.SelectedIndex = 1;
            //tabControlPessoa.TabPages[0].Enabled = false;
            //ButtonSalvar.Enabled = false;
        }

        public Pessoa(List<FuncionarioClasse> funcionarios, FuncionarioClasse funcionario)
        {
            InitializeComponent();
            // atribui o objeto recebido à variável com escopo de classe
            this.funcionario = funcionario;
            this.funcionarios = funcionarios;
            // carrega os valores do Enum para o combobox
            comboBoxCargo.DataSource = Enum.GetValues(typeof(EnumFuncionarioCargo));
            comboBoxCargo.SelectedIndex = 0;
            // carrega os valores do objeto recebido
            textBoxNome.Text = funcionario.Nome;
            dateTimePickerNascimento.Value = funcionario.Nascimento;
            maskedTextBoxCpf.Text = funcionario.Cpf;
            maskedTextBoxEmail.Text = funcionario.Email;
            maskedTextBoxTelefone.Text = funcionario.Telefone;
            comboBoxCargo.Text = "" + (EnumFuncionarioCargo)Enum.Parse(typeof(EnumFuncionarioCargo), funcionario.Cargo.ToString());
            numericUpDownSalario.Value = funcionario.Salario;
            numericUpDownCargaHoraria.Value = funcionario.CargaHoraria;
            textBoxFuncao.Text = funcionario.Funcao;
            tabControlPessoa.SelectedIndex = 1;
            tabControlPessoa.TabPages[0].Enabled = false;
            ButtonSalvar.Enabled = false;
        }

        public Pessoa(List<LeitorClasse> leitores, LeitorClasse leitor)
        {
            InitializeComponent();
            // atribui o objeto recebido à variável com escopo de classe
            this.leitor = leitor;
            this.leitores = leitores;

            // carrega os valores do Enum para o combobox
            comboBoxCargo.DataSource = Enum.GetValues(typeof(EnumFuncionarioCargo));
            comboBoxCargo.SelectedIndex = 0;

            // carrega os valores do objeto recebido
            textBoxNome.Text = leitor.Nome;
            dateTimePickerNascimento.Value = leitor.Nascimento;
            maskedTextBoxCpf.Text = leitor.Cpf;
            maskedTextBoxEmail.Text = leitor.Email;
            maskedTextBoxTelefone.Text = leitor.Telefone;

            listBoxTipoLeitor.Text = leitor.Tipo;
            tabControlPessoa.SelectedIndex = 0;
            tabControlPessoa.TabPages[1].Enabled = false;
            ButtonSalvar.Enabled = false;
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
            if (tabControlPessoa.SelectedIndex == 0)
            {
                // atualiza os dados no objeto
                leitor.Nome = textBoxNome.Text;
                leitor.Nascimento = dateTimePickerNascimento.Value;
                leitor.Cpf = maskedTextBoxCpf.Text;
                leitor.Email = maskedTextBoxEmail.Text;
                leitor.Telefone = maskedTextBoxTelefone.Text;
                leitor.Tipo = listBoxTipoLeitor.Text;
            }
            else
            {
                // atualiza os dados no objeto
                funcionario.Nome = textBoxNome.Text;
                funcionario.Nascimento = dateTimePickerNascimento.Value;
                funcionario.Cpf = maskedTextBoxCpf.Text;
                funcionario.Email = maskedTextBoxEmail.Text;
                funcionario.Telefone = maskedTextBoxTelefone.Text;
                funcionario.Cargo = (int)(EnumFuncionarioCargo)Enum.Parse(typeof(EnumFuncionarioCargo), comboBoxCargo.Text);
                funcionario.Salario = numericUpDownSalario.Value;
                funcionario.CargaHoraria = Convert.ToInt32(numericUpDownCargaHoraria.Value);
                funcionario.Funcao = textBoxFuncao.Text;
            }
            MessageBox.Show("Pessoa editada com sucesso!");
            Close();
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

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (tabControlPessoa.SelectedIndex == 0)
            {
                // exclui o objeto
                leitores.Remove(leitor);
            }
            else if (tabControlPessoa.SelectedIndex == 1)
            {
                // exclui o objeto
                funcionarios.Remove(funcionario);
            }
            MessageBox.Show("Pessoa excluída com sucesso!");
            Close();
        }

        private void listBoxTipoLeitor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
//Nicolas Bastos
