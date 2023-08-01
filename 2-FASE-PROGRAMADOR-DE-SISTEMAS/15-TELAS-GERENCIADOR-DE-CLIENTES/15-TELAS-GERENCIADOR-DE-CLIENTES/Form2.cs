using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15_TELAS_GERENCIADOR_DE_CLIENTES
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        public void atualizaInterface()
        {
            for (int i = 0; i < Program.clientes.Count; i++)
            {
                listView1.Items.Add(Program.clientes[i].usuario.usuario);
            }
            Program.clientes.Clear();
        }

        private void bntSalvar_Click(object sender, EventArgs e)
        {


            Usuario usuario = new Usuario(txtUsuario.Text, txtSenha.Text);
            Cliente cliente = new Cliente(txtNome.Text, int.Parse(txtData.Text), usuario);
            Program.clientes.Add(cliente);
            atualizaInterface();


        }
    }
}
