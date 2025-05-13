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
            textBox1 = new TextBox();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            maskedTextBox1 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            Nascimento = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            maskedTextBox3 = new MaskedTextBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            Leitor = new Label();
            listBox1 = new ListBox();
            comboBox1 = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            textBox2 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button1 = new Button();
            contextMenuStrip3.SuspendLayout();
            groupBox1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
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
            groupBox1.Controls.Add(maskedTextBox3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(Nascimento);
            groupBox1.Controls.Add(maskedTextBox2);
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(25, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(441, 426);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pessoa";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(67, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(293, 27);
            textBox1.TabIndex = 0;
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
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(67, 128);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(293, 27);
            dateTimePicker1.TabIndex = 2;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(67, 200);
            maskedTextBox1.Mask = "000.000.000-00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(291, 27);
            maskedTextBox1.TabIndex = 3;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(65, 286);
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(291, 27);
            maskedTextBox2.TabIndex = 4;
            // 
            // Nascimento
            // 
            Nascimento.AutoSize = true;
            Nascimento.Location = new Point(65, 105);
            Nascimento.Name = "Nascimento";
            Nascimento.Size = new Size(88, 20);
            Nascimento.TabIndex = 6;
            Nascimento.Text = "Nascimento";
            Nascimento.Click += Nascimento_Click;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(67, 177);
            label4.Name = "label4";
            label4.Size = new Size(33, 20);
            label4.TabIndex = 9;
            label4.Text = "CPF";
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(65, 368);
            maskedTextBox3.Mask = "(999) 000-0000";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(291, 27);
            maskedTextBox3.TabIndex = 10;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(495, 30);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(456, 324);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(listBox1);
            tabPage1.Controls.Add(Leitor);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(448, 291);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Leitor";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(numericUpDown2);
            tabPage2.Controls.Add(numericUpDown1);
            tabPage2.Controls.Add(comboBox1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(448, 291);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Funcionário";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Leitor
            // 
            Leitor.AutoSize = true;
            Leitor.Location = new Point(25, 37);
            Leitor.Name = "Leitor";
            Leitor.Size = new Size(50, 20);
            Leitor.TabIndex = 11;
            Leitor.Text = "Nome";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Items.AddRange(new object[] { "Leitor Casual", "Leitor Multifera", "Leitor de Clássicos", "Leitor de Não Ficção", "Leitor Àvido", "Leitor de Ficção", "Leitor Crítico", "Leitor Acadêmico", "Leitor Tradicional", "Outros " });
            listBox1.Location = new Point(25, 66);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(385, 204);
            listBox1.TabIndex = 12;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Gerente", "Atendente", "Caixa", "Estagiário" });
            comboBox1.Location = new Point(28, 75);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(188, 28);
            comboBox1.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(28, 209);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(188, 27);
            numericUpDown1.TabIndex = 1;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(248, 209);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(187, 27);
            numericUpDown2.TabIndex = 2;
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(248, 76);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(188, 27);
            textBox2.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(248, 53);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 11;
            label5.Text = "Função";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(248, 186);
            label6.Name = "label6";
            label6.Size = new Size(102, 20);
            label6.TabIndex = 12;
            label6.Text = "Carga Horária";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(29, 186);
            label7.Name = "label7";
            label7.Size = new Size(55, 20);
            label7.TabIndex = 13;
            label7.Text = "Salário";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(29, 52);
            label8.Name = "label8";
            label8.Size = new Size(49, 20);
            label8.TabIndex = 14;
            label8.Text = "Cargo";
            // 
            // button1
            // 
            button1.Location = new Point(562, 393);
            button1.Name = "button1";
            button1.Size = new Size(342, 29);
            button1.TabIndex = 6;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = true;
            // 
            // Pessoa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(963, 453);
            Controls.Add(button1);
            Controls.Add(tabControl1);
            Controls.Add(groupBox1);
            Name = "Pessoa";
            Text = "Pessoa";
            Load += Pessoa_Load;
            contextMenuStrip3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
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
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox1;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private TextBox textBox1;
        private Label Nascimento;
        private Label label2;
        private Label label3;
        private Label label4;
        private MaskedTextBox maskedTextBox3;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ListBox listBox1;
        private Label Leitor;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox textBox2;
        private Button button1;
    }
}