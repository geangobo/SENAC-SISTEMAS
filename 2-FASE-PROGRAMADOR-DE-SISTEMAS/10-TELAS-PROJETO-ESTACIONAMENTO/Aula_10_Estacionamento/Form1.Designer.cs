namespace Aula_10_Estacionamento
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
            bntFechar = new Button();
            bntRetirar = new Button();
            bntEstacionar = new Button();
            txtPlaca = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            lv1 = new ListView();
            lblVeiculos = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(bntFechar);
            groupBox1.Controls.Add(bntRetirar);
            groupBox1.Controls.Add(bntEstacionar);
            groupBox1.Controls.Add(txtPlaca);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(26, 56);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(311, 321);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Operações";
            // 
            // bntFechar
            // 
            bntFechar.Location = new Point(18, 232);
            bntFechar.Name = "bntFechar";
            bntFechar.Size = new Size(251, 56);
            bntFechar.TabIndex = 6;
            bntFechar.Text = "Fechar o estacionamento";
            bntFechar.UseVisualStyleBackColor = true;
            bntFechar.Click += bntFechar_Click;
            // 
            // bntRetirar
            // 
            bntRetirar.Location = new Point(163, 149);
            bntRetirar.Name = "bntRetirar";
            bntRetirar.Size = new Size(106, 56);
            bntRetirar.TabIndex = 5;
            bntRetirar.Text = "Retirar";
            bntRetirar.UseVisualStyleBackColor = true;
            bntRetirar.Click += bntRetirar_Click;
            // 
            // bntEstacionar
            // 
            bntEstacionar.Location = new Point(18, 149);
            bntEstacionar.Name = "bntEstacionar";
            bntEstacionar.Size = new Size(106, 56);
            bntEstacionar.TabIndex = 3;
            bntEstacionar.Text = "Estacionar";
            bntEstacionar.UseVisualStyleBackColor = true;
            bntEstacionar.Click += bntEstacionar_Click;
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(18, 89);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(251, 23);
            txtPlaca.TabIndex = 4;
            txtPlaca.TextChanged += txtPlaca_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(18, 56);
            label1.Name = "label1";
            label1.Size = new Size(106, 21);
            label1.TabIndex = 3;
            label1.Text = "Digite a placa:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lv1);
            groupBox2.Controls.Add(lblVeiculos);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(408, 56);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(311, 321);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Listagem de veículos";
            // 
            // lv1
            // 
            lv1.Location = new Point(28, 89);
            lv1.Name = "lv1";
            lv1.Size = new Size(256, 214);
            lv1.TabIndex = 6;
            lv1.UseCompatibleStateImageBehavior = false;
            lv1.View = View.List;
            lv1.SelectedIndexChanged += lv1_SelectedIndexChanged;
            // 
            // lblVeiculos
            // 
            lblVeiculos.AutoSize = true;
            lblVeiculos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblVeiculos.Location = new Point(82, 56);
            lblVeiculos.Name = "lblVeiculos";
            lblVeiculos.Size = new Size(19, 21);
            lblVeiculos.TabIndex = 5;
            lblVeiculos.Text = "0";
            lblVeiculos.Click += lblVeiculos_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 56);
            label2.Name = "label2";
            label2.Size = new Size(70, 21);
            label2.TabIndex = 4;
            label2.Text = "Veículos:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtPlaca;
        private Label label1;
        private ListView lv1;
        private Label lblVeiculos;
        private Label label2;
        private Button bntEstacionar;
        private Button bntFechar;
        private Button bntRetirar;
    }
}