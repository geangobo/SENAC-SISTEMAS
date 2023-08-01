namespace _15_TELAS_GERENCIADOR_DE_CLIENTES
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario("admin", "admin");
            Cliente cliente = new Cliente("admin", 0, usuario);

            Program.clientes.Add(cliente);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            string usuario = txtUsuario1.Text;
            string senha = txtSenha1.Text;
            for (int i = 0; i < Program.clientes.Count; i++)
            {
                if (Program.clientes[i].usuario.usuario == usuario && Program.clientes[i].usuario.senha == senha)
                {
                    Form2 gerenciadorCliente = new Form2();
                    gerenciadorCliente.Show();
                }
                else
                {
                    MessageBox.Show("Usuário ou senhas incorretos");
                }
                
            }


        }
    }
}