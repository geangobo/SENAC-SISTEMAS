namespace _15_TELAS_GERENCIADOR_DE_CLIENTES
{
    partial class Form2
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            bntSalvar = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtData = new TextBox();
            label4 = new Label();
            txtNome = new TextBox();
            txtSenha = new TextBox();
            txtUsuario = new TextBox();
            label2 = new Label();
            textBox5 = new TextBox();
            listView1 = new ListView();
            button1 = new Button();
            groupBox2 = new GroupBox();
            label3 = new Label();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 33);
            label1.Name = "label1";
            label1.Size = new Size(207, 15);
            label1.TabIndex = 1;
            label1.Text = "Bem-vindo ao gerenciador de clientes";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(bntSalvar);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtData);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(txtSenha);
            groupBox1.Controls.Add(txtUsuario);
            groupBox1.Location = new Point(30, 81);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(240, 286);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastro";
            // 
            // bntSalvar
            // 
            bntSalvar.Location = new Point(9, 246);
            bntSalvar.Name = "bntSalvar";
            bntSalvar.Size = new Size(192, 23);
            bntSalvar.TabIndex = 14;
            bntSalvar.Text = "Salvar";
            bntSalvar.UseVisualStyleBackColor = true;
            bntSalvar.Click += bntSalvar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 197);
            label5.Name = "label5";
            label5.Size = new Size(97, 15);
            label5.TabIndex = 15;
            label5.Text = "Ano nascimento:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 142);
            label6.Name = "label6";
            label6.Size = new Size(97, 15);
            label6.TabIndex = 16;
            label6.Text = "Nome completo:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 32);
            label7.Name = "label7";
            label7.Size = new Size(93, 15);
            label7.TabIndex = 17;
            label7.Text = "Digite o usuário:";
            // 
            // txtData
            // 
            txtData.Location = new Point(9, 215);
            txtData.Name = "txtData";
            txtData.Size = new Size(191, 23);
            txtData.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 84);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 14;
            label4.Text = "Digite a senha:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(9, 160);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(191, 23);
            txtNome.TabIndex = 6;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(9, 102);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '#';
            txtSenha.Size = new Size(191, 23);
            txtSenha.TabIndex = 5;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(9, 50);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(191, 23);
            txtUsuario.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 19);
            label2.Name = "label2";
            label2.Size = new Size(143, 15);
            label2.TabIndex = 3;
            label2.Text = "Buscar cliente pelo nome:";
            label2.Click += label2_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(6, 37);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(191, 23);
            textBox5.TabIndex = 8;
            // 
            // listView1
            // 
            listView1.Location = new Point(6, 172);
            listView1.Name = "listView1";
            listView1.Size = new Size(192, 97);
            listView1.TabIndex = 9;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.List;
            // 
            // button1
            // 
            button1.Location = new Point(559, 158);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(listView1);
            groupBox2.Location = new Point(485, 81);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 286);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Busca de clientes";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 154);
            label3.Name = "label3";
            label3.Size = new Size(118, 15);
            label3.TabIndex = 13;
            label3.Text = "Clientes cadastrados:";
            // 
            // button2
            // 
            button2.Location = new Point(6, 66);
            button2.Name = "button2";
            button2.Size = new Size(192, 23);
            button2.TabIndex = 12;
            button2.Text = "Procurar";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtData;
        private TextBox txtNome;
        private TextBox txtSenha;
        private TextBox txtUsuario;
        private Label label2;
        private TextBox textBox5;
        private ListView listView1;
        private Button button1;
        private GroupBox groupBox2;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label4;
        private Label label3;
        private Button button2;
        private Button bntSalvar;
    }
}