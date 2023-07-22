namespace Aula_07_funcoes
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
            bntMensagem = new Button();
            bntMensagem2 = new Button();
            textBox1 = new TextBox();
            bntSalvar = new Button();
            lblDinheiro = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // bntMensagem
            // 
            bntMensagem.Location = new Point(12, 41);
            bntMensagem.Name = "bntMensagem";
            bntMensagem.Size = new Size(238, 96);
            bntMensagem.TabIndex = 0;
            bntMensagem.Text = "Mostrar Mensagem";
            bntMensagem.UseVisualStyleBackColor = true;
            bntMensagem.Click += button1_Click;
            // 
            // bntMensagem2
            // 
            bntMensagem2.Location = new Point(42, 157);
            bntMensagem2.Name = "bntMensagem2";
            bntMensagem2.Size = new Size(175, 113);
            bntMensagem2.TabIndex = 1;
            bntMensagem2.Text = "Mostrar nome";
            bntMensagem2.UseVisualStyleBackColor = true;
            bntMensagem2.Click += bntMensagem2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(61, 293);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // bntSalvar
            // 
            bntSalvar.Location = new Point(394, 157);
            bntSalvar.Name = "bntSalvar";
            bntSalvar.Size = new Size(200, 58);
            bntSalvar.TabIndex = 3;
            bntSalvar.Text = "Salvar";
            bntSalvar.UseVisualStyleBackColor = true;
            bntSalvar.Click += bntSalvar_Click;
            // 
            // lblDinheiro
            // 
            lblDinheiro.AutoSize = true;
            lblDinheiro.Location = new Point(442, 82);
            lblDinheiro.Name = "lblDinheiro";
            lblDinheiro.Size = new Size(29, 15);
            lblDinheiro.TabIndex = 4;
            lblDinheiro.Text = "R$ 0";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(442, 114);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(lblDinheiro);
            Controls.Add(bntSalvar);
            Controls.Add(textBox1);
            Controls.Add(bntMensagem2);
            Controls.Add(bntMensagem);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bntMensagem;
        private Button bntMensagem2;
        private TextBox textBox1;
        private Button bntSalvar;
        private Label lblDinheiro;
        private TextBox textBox2;
    }
}