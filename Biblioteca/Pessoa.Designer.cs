namespace Biblioteca
{
    partial class Pessoa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            contextMenuStrip3 = new ContextMenuStrip(components);
            dfgbdbdToolStripMenuItem = new ToolStripMenuItem();
            bdfbdbdbToolStripMenuItem = new ToolStripMenuItem();
            toolTip1 = new ToolTip(components);
            toolTip2 = new ToolTip(components);
            toolTip3 = new ToolTip(components);
            groupBox1 = new GroupBox();
            maskedTextBoxTelefone = new MaskedTextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            Nascimento = new Label();
            maskedTextBoxEmail = new MaskedTextBox();
            maskedTextBoxCpf = new MaskedTextBox();
            dateTimePickerNascimento = new DateTimePicker();
            label1 = new Label();
            textBoxNome = new TextBox();
            tabControlPessoa = new TabControl();
            tabPage1 = new TabPage();
            dataGridView1 = new DataGridView();
            button3 = new Button();
            button2 = new Button();
            listBoxTipoLeitor = new ListBox();
            Leitor = new Label();
            tabPage2 = new TabPage();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            textBoxFuncao = new TextBox();
            numericUpDownCargaHoraria = new NumericUpDown();
            numericUpDownSalario = new NumericUpDown();
            comboBoxCargo = new ComboBox();
            ButtonSalvar = new Button();
            buttonEditar = new Button();
            buttonExcluir = new Button();
            contextMenuStrip3.SuspendLayout();
            groupBox1.SuspendLayout();
            tabControlPessoa.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCargaHoraria).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSalario).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(20, 20);
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // contextMenuStrip3
            // 
            contextMenuStrip3.ImageScalingSize = new Size(20, 20);
            contextMenuStrip3.Items.AddRange(new ToolStripItem[] { dfgbdbdToolStripMenuItem, bdfbdbdbToolStripMenuItem });
            contextMenuStrip3.Name = "contextMenuStrip3";
            contextMenuStrip3.Size = new Size(147, 52);
            // 
            // dfgbdbdToolStripMenuItem
            // 
            dfgbdbdToolStripMenuItem.Name = "dfgbdbdToolStripMenuItem";
            dfgbdbdToolStripMenuItem.Size = new Size(146, 24);
            dfgbdbdToolStripMenuItem.Text = "dfgbdbd";
            // 
            // bdfbdbdbToolStripMenuItem
            // 
            bdfbdbdbToolStripMenuItem.Name = "bdfbdbdbToolStripMenuItem";
            bdfbdbdbToolStripMenuItem.Size = new Size(146, 24);
            bdfbdbdbToolStripMenuItem.Text = "bdfbdbdb";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(maskedTextBoxTelefone);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(Nascimento);
            groupBox1.Controls.Add(maskedTextBoxEmail);
            groupBox1.Controls.Add(maskedTextBoxCpf);
            groupBox1.Controls.Add(dateTimePickerNascimento);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBoxNome);
            groupBox1.Location = new Point(25, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(441, 426);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pessoa";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // maskedTextBoxTelefone
            // 
            maskedTextBoxTelefone.BackColor = Color.FromArgb(192, 255, 192);
            maskedTextBoxTelefone.ForeColor = SystemColors.HighlightText;
            maskedTextBoxTelefone.Location = new Point(65, 368);
            maskedTextBoxTelefone.Mask = "(999) 000-0000";
            maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            maskedTextBoxTelefone.Size = new Size(291, 27);
            maskedTextBoxTelefone.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(67, 177);
            label4.Name = "label4";
            label4.Size = new Size(33, 20);
            label4.TabIndex = 9;
            label4.Text = "CPF";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 345);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 8;
            label3.Text = "TELEFONE";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 263);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 7;
            label2.Text = "EMAIL";
            label2.Click += label2_Click;
            // 
            // Nascimento
            // 
            Nascimento.AutoSize = true;
            Nascimento.ForeColor = Color.Black;
            Nascimento.Location = new Point(65, 105);
            Nascimento.Name = "Nascimento";
            Nascimento.Size = new Size(88, 20);
            Nascimento.TabIndex = 6;
            Nascimento.Text = "Nascimento";
            Nascimento.Click += Nascimento_Click;
            // 
            // maskedTextBoxEmail
            // 
            maskedTextBoxEmail.BackColor = Color.FromArgb(192, 255, 192);
            maskedTextBoxEmail.ForeColor = SystemColors.HighlightText;
            maskedTextBoxEmail.Location = new Point(65, 286);
            maskedTextBoxEmail.Name = "maskedTextBoxEmail";
            maskedTextBoxEmail.Size = new Size(291, 27);
            maskedTextBoxEmail.TabIndex = 4;
            // 
            // maskedTextBoxCpf
            // 
            maskedTextBoxCpf.BackColor = Color.FromArgb(192, 255, 192);
            maskedTextBoxCpf.ForeColor = SystemColors.HighlightText;
            maskedTextBoxCpf.Location = new Point(67, 200);
            maskedTextBoxCpf.Mask = "000.000.000-00";
            maskedTextBoxCpf.Name = "maskedTextBoxCpf";
            maskedTextBoxCpf.Size = new Size(291, 27);
            maskedTextBoxCpf.TabIndex = 3;
            maskedTextBoxCpf.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // dateTimePickerNascimento
            // 
            dateTimePickerNascimento.CalendarMonthBackground = Color.FromArgb(192, 255, 192);
            dateTimePickerNascimento.CalendarTitleForeColor = Color.Aqua;
            dateTimePickerNascimento.CalendarTrailingForeColor = Color.FromArgb(255, 192, 128);
            dateTimePickerNascimento.Format = DateTimePickerFormat.Time;
            dateTimePickerNascimento.Location = new Point(67, 128);
            dateTimePickerNascimento.Name = "dateTimePickerNascimento";
            dateTimePickerNascimento.Size = new Size(293, 27);
            dateTimePickerNascimento.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 39);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 1;
            label1.Text = "Nome";
            // 
            // textBoxNome
            // 
            textBoxNome.BackColor = SystemColors.GradientActiveCaption;
            textBoxNome.ForeColor = SystemColors.HighlightText;
            textBoxNome.Location = new Point(67, 62);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(293, 27);
            textBoxNome.TabIndex = 0;
            textBoxNome.TextChanged += textBox1_TextChanged;
            // 
            // tabControlPessoa
            // 
            tabControlPessoa.Controls.Add(tabPage1);
            tabControlPessoa.Controls.Add(tabPage2);
            tabControlPessoa.Location = new Point(495, 30);
            tabControlPessoa.Name = "tabControlPessoa";
            tabControlPessoa.SelectedIndex = 0;
            tabControlPessoa.Size = new Size(828, 324);
            tabControlPessoa.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(listBoxTipoLeitor);
            tabPage1.Controls.Add(Leitor);
            tabPage1.ForeColor = SystemColors.ActiveCaptionText;
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(820, 291);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Leitor";
            tabPage1.Click += tabPage1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(335, 37);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(449, 188);
            dataGridView1.TabIndex = 16;
            // 
            // button3
            // 
            button3.Location = new Point(634, 241);
            button3.Name = "button3";
            button3.Size = new Size(150, 29);
            button3.TabIndex = 15;
            button3.Text = "Del Exemplar\r\n";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(395, 241);
            button2.Name = "button2";
            button2.Size = new Size(169, 29);
            button2.TabIndex = 14;
            button2.Text = "add Exemplar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listBoxTipoLeitor
            // 
            listBoxTipoLeitor.BackColor = SystemColors.Highlight;
            listBoxTipoLeitor.ForeColor = SystemColors.HighlightText;
            listBoxTipoLeitor.FormattingEnabled = true;
            listBoxTipoLeitor.Items.AddRange(new object[] { "Leitor Casual", "Leitor Multifera", "Leitor de Clássicos", "Leitor de Não Ficção", "Leitor Àvido", "Leitor de Ficção", "Leitor Crítico", "Leitor Acadêmico", "Leitor Tradicional", "Outros " });
            listBoxTipoLeitor.Location = new Point(25, 66);
            listBoxTipoLeitor.Name = "listBoxTipoLeitor";
            listBoxTipoLeitor.Size = new Size(273, 204);
            listBoxTipoLeitor.TabIndex = 12;
            listBoxTipoLeitor.SelectedIndexChanged += listBoxTipoLeitor_SelectedIndexChanged;
            // 
            // Leitor
            // 
            Leitor.AutoSize = true;
            Leitor.Location = new Point(25, 37);
            Leitor.Name = "Leitor";
            Leitor.Size = new Size(39, 20);
            Leitor.TabIndex = 11;
            Leitor.Text = "Tipo";
            Leitor.Click += Leitor_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.Menu;
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(textBoxFuncao);
            tabPage2.Controls.Add(numericUpDownCargaHoraria);
            tabPage2.Controls.Add(numericUpDownSalario);
            tabPage2.Controls.Add(comboBoxCargo);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(820, 291);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Funcionário";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(141, 51);
            label8.Name = "label8";
            label8.Size = new Size(49, 20);
            label8.TabIndex = 14;
            label8.Text = "Cargo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(141, 186);
            label7.Name = "label7";
            label7.Size = new Size(55, 20);
            label7.TabIndex = 13;
            label7.Text = "Salário";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(514, 186);
            label6.Name = "label6";
            label6.Size = new Size(102, 20);
            label6.TabIndex = 12;
            label6.Text = "Carga Horária";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(514, 52);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 11;
            label5.Text = "Função";
            // 
            // textBoxFuncao
            // 
            textBoxFuncao.Location = new Point(514, 75);
            textBoxFuncao.Name = "textBoxFuncao";
            textBoxFuncao.Size = new Size(188, 27);
            textBoxFuncao.TabIndex = 3;
            // 
            // numericUpDownCargaHoraria
            // 
            numericUpDownCargaHoraria.Location = new Point(514, 214);
            numericUpDownCargaHoraria.Name = "numericUpDownCargaHoraria";
            numericUpDownCargaHoraria.Size = new Size(187, 27);
            numericUpDownCargaHoraria.TabIndex = 2;
            numericUpDownCargaHoraria.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // numericUpDownSalario
            // 
            numericUpDownSalario.Location = new Point(140, 209);
            numericUpDownSalario.Maximum = new decimal(new int[] { -727379969, 232, 0, 0 });
            numericUpDownSalario.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownSalario.Name = "numericUpDownSalario";
            numericUpDownSalario.Size = new Size(188, 27);
            numericUpDownSalario.TabIndex = 1;
            numericUpDownSalario.Value = new decimal(new int[] { 99999999, 0, 0, 0 });
            // 
            // comboBoxCargo
            // 
            comboBoxCargo.FormattingEnabled = true;
            comboBoxCargo.Items.AddRange(new object[] { "Gerente", "Atendente", "Caixa", "Estagiário" });
            comboBoxCargo.Location = new Point(140, 74);
            comboBoxCargo.Name = "comboBoxCargo";
            comboBoxCargo.Size = new Size(188, 28);
            comboBoxCargo.TabIndex = 0;
            comboBoxCargo.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // ButtonSalvar
            // 
            ButtonSalvar.Location = new Point(562, 393);
            ButtonSalvar.Name = "ButtonSalvar";
            ButtonSalvar.Size = new Size(205, 29);
            ButtonSalvar.TabIndex = 6;
            ButtonSalvar.Text = "Salvar";
            ButtonSalvar.UseVisualStyleBackColor = true;
            ButtonSalvar.Click += button1_Click;
            // 
            // buttonEditar
            // 
            buttonEditar.Location = new Point(834, 393);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(205, 29);
            buttonEditar.TabIndex = 7;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = true;
            buttonEditar.Click += button4_Click;
            // 
            // buttonExcluir
            // 
            buttonExcluir.Location = new Point(1091, 393);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(205, 29);
            buttonExcluir.TabIndex = 8;
            buttonExcluir.Text = "Excluir";
            buttonExcluir.UseVisualStyleBackColor = true;
            buttonExcluir.Click += buttonExcluir_Click;
            // 
            // Pessoa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1353, 453);
            Controls.Add(buttonExcluir);
            Controls.Add(buttonEditar);
            Controls.Add(ButtonSalvar);
            Controls.Add(tabControlPessoa);
            Controls.Add(groupBox1);
            Name = "Pessoa";
            Text = "Pessoa";
            TransparencyKey = Color.Transparent;
            Load += Pessoa_Load;
            contextMenuStrip3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabControlPessoa.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCargaHoraria).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSalario).EndInit();
            ResumeLayout(false);

        }


        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private ContextMenuStrip contextMenuStrip3;
        private ToolStripMenuItem dfgbdbdToolStripMenuItem;
        private ToolStripMenuItem bdfbdbdbToolStripMenuItem;
        private ToolTip toolTip1;
        private ToolTip toolTip2;
        private ToolTip toolTip3;
        private GroupBox groupBox1;
        private MaskedTextBox maskedTextBoxEmail;
        private MaskedTextBox maskedTextBoxCpf;
        private DateTimePicker dateTimePickerNascimento;
        private Label label1;
        private TextBox textBoxNome;
        private Label Nascimento;
        private Label label2;
        private Label label3;
        private Label label4;
        private MaskedTextBox maskedTextBoxTelefone;
        private TabControl tabControlPessoa;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ListBox listBoxTipoLeitor;
        private Label Leitor;
        private NumericUpDown numericUpDownCargaHoraria;
        private NumericUpDown numericUpDownSalario;
        private ComboBox comboBoxCargo;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox textBoxFuncao;
        private Button ButtonSalvar;
        private Button button3;
        private Button button2;
        private Button buttonEditar;
        private Button buttonExcluir;
        private DataGridView dataGridView1;
    }
    //Nícolas Bastos
}