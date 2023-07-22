namespace Aula8_Estoque
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
            groupBox1 = new GroupBox();
            btnCancelar = new Button();
            btnSalvar = new Button();
            txtQuantidade = new TextBox();
            txtNome = new TextBox();
            label1 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            lblQuantidade = new Label();
            label5 = new Label();
            label3 = new Label();
            lblCadastrados = new Label();
            groupBox3 = new GroupBox();
            btnDeletar = new Button();
            btnUltimo = new Button();
            btnPrimeiro = new Button();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnSalvar);
            groupBox1.Controls.Add(txtQuantidade);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(84, 69);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 166);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastro";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(109, 137);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(78, 23);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(6, 137);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(78, 23);
            btnSalvar.TabIndex = 3;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(6, 103);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(181, 23);
            txtQuantidade.TabIndex = 5;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(6, 49);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(181, 23);
            txtNome.TabIndex = 3;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 31);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 3;
            label1.Text = "Nome de produto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 85);
            label2.Name = "label2";
            label2.Size = new Size(137, 15);
            label2.TabIndex = 4;
            label2.Text = "Quantidade em estoque:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblQuantidade);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(lblCadastrados);
            groupBox2.Location = new Point(467, 69);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 141);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Informações";
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblQuantidade.Location = new Point(95, 112);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(14, 15);
            lblQuantidade.TabIndex = 9;
            lblQuantidade.Text = "0";
            lblQuantidade.Click += lblQuantidade_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 82);
            label5.Name = "label5";
            label5.Size = new Size(137, 15);
            label5.TabIndex = 8;
            label5.Text = "Quantidade em estoque:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 32);
            label3.Name = "label3";
            label3.Size = new Size(124, 15);
            label3.TabIndex = 6;
            label3.Text = "Produtos cadastrados:";
            // 
            // lblCadastrados
            // 
            lblCadastrados.AutoSize = true;
            lblCadastrados.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCadastrados.Location = new Point(95, 58);
            lblCadastrados.Name = "lblCadastrados";
            lblCadastrados.Size = new Size(14, 15);
            lblCadastrados.TabIndex = 7;
            lblCadastrados.Text = "0";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnDeletar);
            groupBox3.Controls.Add(btnUltimo);
            groupBox3.Controls.Add(btnPrimeiro);
            groupBox3.Location = new Point(84, 277);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(583, 100);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Operações";
            // 
            // btnDeletar
            // 
            btnDeletar.Location = new Point(318, 44);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(188, 23);
            btnDeletar.TabIndex = 8;
            btnDeletar.Text = "Deletar o PRIMEIRO produto";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // btnUltimo
            // 
            btnUltimo.Location = new Point(6, 61);
            btnUltimo.Name = "btnUltimo";
            btnUltimo.Size = new Size(190, 23);
            btnUltimo.TabIndex = 7;
            btnUltimo.Text = "Ver o ÚLTIMO produto";
            btnUltimo.UseVisualStyleBackColor = true;
            btnUltimo.Click += btnUltimo_Click;
            // 
            // btnPrimeiro
            // 
            btnPrimeiro.Location = new Point(6, 22);
            btnPrimeiro.Name = "btnPrimeiro";
            btnPrimeiro.Size = new Size(188, 23);
            btnPrimeiro.TabIndex = 6;
            btnPrimeiro.Text = "Ver o PRIMEIRO produto";
            btnPrimeiro.UseVisualStyleBackColor = true;
            btnPrimeiro.Click += btnPrimeiro_Click;
            // 
            // button1
            // 
            button1.Location = new Point(758, 231);
            button1.Name = "button1";
            button1.Size = new Size(174, 23);
            button1.TabIndex = 9;
            button1.Text = "Buscar função do utilidades";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 450);
            Controls.Add(button1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnSalvar;
        private TextBox txtQuantidade;
        private TextBox txtNome;
        private Label label1;
        private Label label2;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label3;
        private Label lblCadastrados;
        private Label lblQuantidade;
        private Label label5;
        private Button btnDeletar;
        private Button btnUltimo;
        private Button btnPrimeiro;
        private Button btnCancelar;
        private Button button1;
    }
}