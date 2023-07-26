using _13_CONSOLE_CLASSES_POO;

namespace _13_TELAS_CLASSES
{
    public partial class Form1 : Form
    {
        //Criando uma lista global para atenter todo projeto
        List<Pessoa> pessoas = new List<Pessoa>();

        public Form1()
        {
            InitializeComponent();
        }
        public void atualizarInterface()
        {
            
            for (int i = 0; i < pessoas.Count; i++)
            {
                listView1.Items.Add(pessoas[i].nome);
            }
            pessoas.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            int idade = int.Parse(txtIdade.Text);
            string rua = txtEndereco.Text;
            string cidade = txtCidade.Text;

            Pessoa pessoa = new Pessoa(nome, idade, rua, cidade); 
            pessoas.Add(pessoa);
            atualizarInterface();



            
        }
    }
}