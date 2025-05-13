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
            cadastro.ImageAlign = ContentAlignment.TopCenter;
            cadastro.Location = new Point(57, 129);
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
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(57, 271);
            button1.Name = "button1";
            button1.Size = new Size(311, 65);
            button1.TabIndex = 1;
            button1.Text = "Cadastro Exemplar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(430, 498);
            Controls.Add(button1);
            Controls.Add(cadastro);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private Button cadastro;
        private Button button1;
    }
}
