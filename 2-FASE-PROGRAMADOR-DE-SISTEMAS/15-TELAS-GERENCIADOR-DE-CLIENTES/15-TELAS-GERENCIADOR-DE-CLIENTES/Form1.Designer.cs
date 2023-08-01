namespace _15_TELAS_GERENCIADOR_DE_CLIENTES
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtUsuario1 = new TextBox();
            txtSenha1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(158, 81);
            label1.Name = "label1";
            label1.Size = new Size(151, 15);
            label1.TabIndex = 0;
            label1.Text = "Faça o login para continuar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(98, 152);
            label2.Name = "label2";
            label2.Size = new Size(114, 15);
            label2.TabIndex = 1;
            label2.Text = "Digite o seu usuário:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(98, 230);
            label3.Name = "label3";
            label3.Size = new Size(105, 15);
            label3.TabIndex = 2;
            label3.Text = "Digite a sua senha:";
            // 
            // txtUsuario1
            // 
            txtUsuario1.Location = new Point(112, 170);
            txtUsuario1.Name = "txtUsuario1";
            txtUsuario1.Size = new Size(231, 23);
            txtUsuario1.TabIndex = 3;
            // 
            // txtSenha1
            // 
            txtSenha1.Location = new Point(112, 248);
            txtSenha1.Name = "txtSenha1";
            txtSenha1.Size = new Size(231, 23);
            txtSenha1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(173, 306);
            button1.Name = "button1";
            button1.Size = new Size(136, 43);
            button1.TabIndex = 5;
            button1.Text = "Entrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 417);
            Controls.Add(button1);
            Controls.Add(txtSenha1);
            Controls.Add(txtUsuario1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtUsuario1;
        private TextBox txtSenha1;
        private Button button1;
    }
}