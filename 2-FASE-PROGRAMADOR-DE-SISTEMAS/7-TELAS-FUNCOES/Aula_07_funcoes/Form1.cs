namespace Aula_07_funcoes
{
    public partial class Form1 : Form
    {
        //Variáveis globais ficam aqui
        public Form1()
        {
            InitializeComponent();
        }
        //Minhas funções ficam aqui: 
        //Função do tipo void --- Função criada! 
        void mostrarMensagem()
        {
            MessageBox.Show("Olá seja bem-vinde");
        }

        void mostrarNome()
        {
            string nome = textBox1.Text;
            MessageBox.Show("Olá " + nome);
        }
        //Função para converter dinheiro -- Com parametros --> Nessa função será obrigado a 
        //Apresentar um label, logo, a função não funciona sem label. Com isso, quem chamar
        //A função será obrigado a usar um label.
        double converterDinheiro(Label dimdim)
        {
            double dinheiro = double.Parse(dimdim.Text.Replace("R$ ", ""));
            return dinheiro;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Programando botão:Usando funções
            mostrarMensagem();


        }

        private void bntMensagem2_Click(object sender, EventArgs e)
        {
            //Assim, aparece mensagens sucessivas após a primeira chamada
            //Logo a ordem importa. 
            mostrarNome(); mostrarMensagem();
        }

        private void bntSalvar_Click(object sender, EventArgs e)
        {
            double valor = double.Parse(textBox2.Text);
            //converterDinheiro(lblDinheiro);
            double dinheiro = converterDinheiro(lblDinheiro);
            double soma = valor + dinheiro;
            lblDinheiro.Text = "R$ " + soma;

        }
    }
}