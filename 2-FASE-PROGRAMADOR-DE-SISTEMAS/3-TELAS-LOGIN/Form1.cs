using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_aula_3_login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user;
            string password; 

            user = txtUsuario.Text;
            password = txtPassword.Text;

            if (password == "1234" && user == "geangobo")
            {
                MessageBox.Show($"Seja bem-vindo usuário: {user}");
            }
            else
            {
                MessageBox.Show($"Usuário: {user} não está cadastrado ou errou a senha");
            }
            

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
