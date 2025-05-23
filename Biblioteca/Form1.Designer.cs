using System.Windows.Forms;

namespace Biblioteca
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            cadastro = new Button();
            button1 = new Button();
            Funcionários = new TabControl();
            tabPage1 = new TabPage();
            dataGridViewFuncionario = new DataGridView();
            dataGridView1 = new DataGridView();
            tabPage2 = new TabPage();
            dataGridViewLeitores = new DataGridView();
            tabPage3 = new TabPage();
            dataGridViewExemplares = new DataGridView();
            Funcionários.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFuncionario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLeitores).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewExemplares).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // cadastro
            // 
            cadastro.BackColor = SystemColors.InactiveBorder;
            cadastro.FlatAppearance.BorderColor = Color.FromArgb(255, 255, 128);
            cadastro.ForeColor = SystemColors.HotTrack;
            cadastro.ImageAlign = ContentAlignment.TopCenter;
            cadastro.Location = new Point(12, 25);
            cadastro.Name = "cadastro";
            cadastro.Size = new Size(311, 65);
            cadastro.TabIndex = 0;
            cadastro.Text = "Cadastrar Pessoa";
            cadastro.UseVisualStyleBackColor = false;
            cadastro.Click += button1_Click_1;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.InactiveBorder;
            button1.FlatAppearance.BorderColor = Color.FromArgb(255, 255, 128);
            button1.ForeColor = SystemColors.HotTrack;
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(12, 112);
            button1.Name = "button1";
            button1.Size = new Size(311, 65);
            button1.TabIndex = 1;
            button1.Text = "Cadastro Exemplar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_2;
            // 
            // Funcionários
            // 
            Funcionários.Controls.Add(tabPage1);
            Funcionários.Controls.Add(tabPage2);
            Funcionários.Controls.Add(tabPage3);
            Funcionários.Location = new Point(329, 25);
            Funcionários.Name = "Funcionários";
            Funcionários.SelectedIndex = 0;
            Funcionários.Size = new Size(1046, 461);
            Funcionários.TabIndex = 2;
            
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridViewFuncionario);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1038, 428);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Funcionários";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFuncionario
            // 
            dataGridViewFuncionario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFuncionario.Dock = DockStyle.Fill;
            dataGridViewFuncionario.Location = new Point(3, 3);
            dataGridViewFuncionario.Name = "dataGridViewFuncionario";
            dataGridViewFuncionario.RowHeadersWidth = 51;
            dataGridViewFuncionario.Size = new Size(1032, 422);
            dataGridViewFuncionario.TabIndex = 1;
            dataGridViewFuncionario.DoubleClick += dataGridViewFuncionario_DoubleClick;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(211, 187);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(8, 8);
            dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridViewLeitores);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1038, 428);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Leitores";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // dataGridViewLeitores
            // 
            dataGridViewLeitores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLeitores.Dock = DockStyle.Fill;
            dataGridViewLeitores.Location = new Point(3, 3);
            dataGridViewLeitores.Name = "dataGridViewLeitores";
            dataGridViewLeitores.RowHeadersWidth = 51;
            dataGridViewLeitores.Size = new Size(1032, 422);
            dataGridViewLeitores.TabIndex = 0;
            dataGridViewLeitores.CellContentClick += dataGridView2_CellContentClick;
            dataGridViewLeitores.DoubleClick += dataGridViewLeitores_DoubleClick;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dataGridViewExemplares);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1038, 428);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Exemplares";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridViewExemplares
            // 
            dataGridViewExemplares.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewExemplares.Dock = DockStyle.Fill;
            dataGridViewExemplares.Location = new Point(0, 0);
            dataGridViewExemplares.Name = "dataGridViewExemplares";
            dataGridViewExemplares.RowHeadersWidth = 51;
            dataGridViewExemplares.Size = new Size(1038, 428);
            dataGridViewExemplares.TabIndex = 0;
            dataGridViewExemplares.DoubleClick += dataGridViewExemplares_DoubleClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(1418, 498);
            Controls.Add(Funcionários);
            Controls.Add(button1);
            Controls.Add(cadastro);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Funcionários.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewFuncionario).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewLeitores).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewExemplares).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private Button cadastro;
        private Button button1;

        private BibliotecaServicoClass bibliotecaService = new();
        // Exemplo de declaração dos controles
        private NumericUpDown numericUpDown2;
        private TextBox textBoxAutor;
        private TextBox textBoxISBN;
        private Button buttonAdicionarLivro;



        private void buttonAdicionarLivro_Click(object sender, EventArgs e)
        {
            //var livro = new LivroClasse
            //{
            //    Titulo = numericUpDown2.Text,
            //    Autor = textBoxAutor.Text,
            //    ISBN = textBoxISBN.Text
            //};
            ////bibliotecaService.AdicionarLivro(livro);
            MessageBox.Show("Livro adicionado!");
        }
        private TabControl Funcionários;
        private TabPage tabPage1;
        private DataGridView dataGridViewFuncionario;
        private DataGridView dataGridView1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        public DataGridView dataGridViewLeitores;
        private DataGridView dataGridViewExemplares;
    }
}
//Nicolas Bastos