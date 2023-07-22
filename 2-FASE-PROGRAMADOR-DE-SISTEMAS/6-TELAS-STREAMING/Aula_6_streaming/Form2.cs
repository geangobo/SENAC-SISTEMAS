using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_6_streaming
{

    public partial class Form2 : Form
    {

        public string titulo, descricao, img_caminho, link_video;

        public Form2()
        {
            InitializeComponent();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = titulo;
            lblDescricao.Text = descricao;
            imgFundo.ImageLocation = img_caminho;
            wvvideo.Source = new Uri(link_video);


        }

        private void btnAssistir_Click(object sender, EventArgs e)
        {
            wvvideo.Visible = true;
        }
    }
}
