namespace Aula_6_streaming
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
            lblTitulo = new Label();
            btnAssistir = new Button();
            lblDescricao = new Label();
            imgFundo = new PictureBox();
            wvvideo = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)imgFundo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wvvideo).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblTitulo.Location = new Point(64, 114);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(55, 21);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Título";
            lblTitulo.Click += lblTitulo_Click;
            // 
            // btnAssistir
            // 
            btnAssistir.Location = new Point(53, 155);
            btnAssistir.Name = "btnAssistir";
            btnAssistir.Size = new Size(75, 23);
            btnAssistir.TabIndex = 1;
            btnAssistir.Text = "Assistir";
            btnAssistir.UseVisualStyleBackColor = true;
            btnAssistir.Click += btnAssistir_Click;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(38, 202);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(117, 15);
            lblDescricao.TabIndex = 2;
            lblDescricao.Text = "Descrição longa aqui";
            // 
            // imgFundo
            // 
            imgFundo.Location = new Point(-1, -1);
            imgFundo.Name = "imgFundo";
            imgFundo.Size = new Size(798, 451);
            imgFundo.SizeMode = PictureBoxSizeMode.Zoom;
            imgFundo.TabIndex = 3;
            imgFundo.TabStop = false;
            // 
            // wvvideo
            // 
            wvvideo.AllowExternalDrop = true;
            wvvideo.CreationProperties = null;
            wvvideo.DefaultBackgroundColor = Color.White;
            wvvideo.Location = new Point(53, 155);
            wvvideo.Name = "wvvideo";
            wvvideo.Size = new Size(75, 23);
            wvvideo.TabIndex = 4;
            wvvideo.ZoomFactor = 1D;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(wvvideo);
            Controls.Add(lblDescricao);
            Controls.Add(btnAssistir);
            Controls.Add(lblTitulo);
            Controls.Add(imgFundo);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)imgFundo).EndInit();
            ((System.ComponentModel.ISupportInitialize)wvvideo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Button btnAssistir;
        private Label lblDescricao;
        private PictureBox imgFundo;
        private Microsoft.Web.WebView2.WinForms.WebView2 wvvideo;
    }
}