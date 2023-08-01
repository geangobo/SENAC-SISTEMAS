namespace _13_TELAS_CLASSES
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
            label4 = new Label();
            txtNome = new TextBox();
            txtIdade = new TextBox();
            txtEndereco = new TextBox();
            txtCidade = new TextBox();
            btnCadastrar = new Button();
            listView1 = new ListView();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(134, 81);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(133, 135);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Idade:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(133, 189);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 2;
            label3.Text = "Endereço:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(133, 247);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 3;
            label4.Text = "Cidade:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(133, 99);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(239, 23);
            txtNome.TabIndex = 4;
            txtNome.TextChanged += textBox1_TextChanged;
            // 
            // txtIdade
            // 
            txtIdade.Location = new Point(133, 153);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(239, 23);
            txtIdade.TabIndex = 5;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(133, 207);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(239, 23);
            txtEndereco.TabIndex = 6;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(133, 265);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(239, 23);
            txtCidade.TabIndex = 7;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(162, 309);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(183, 40);
            btnCadastrar.TabIndex = 8;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(508, 81);
            listView1.Name = "listView1";
            listView1.Size = new Size(242, 268);
            listView1.TabIndex = 9;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.List;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listView1);
            Controls.Add(btnCadastrar);
            Controls.Add(txtCidade);
            Controls.Add(txtEndereco);
            Controls.Add(txtIdade);
            Controls.Add(txtNome);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNome;
        private TextBox txtIdade;
        private TextBox txtEndereco;
        private TextBox txtCidade;
        private Button btnCadastrar;
        private ListView listView1;
    }
}