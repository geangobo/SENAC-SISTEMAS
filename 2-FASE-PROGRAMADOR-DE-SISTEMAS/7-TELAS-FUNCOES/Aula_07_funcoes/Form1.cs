namespace Aula_07_funcoes
{
    public partial class Form1 : Form
    {
        //Vari�veis globais ficam aqui
        public Form1()
        {
            InitializeComponent();
        }
        //Minhas fun��es ficam aqui: 
        //Fun��o do tipo void --- Fun��o criada! 
        void mostrarMensagem()
        {
            MessageBox.Show("Ol� seja bem-vinde");
        }

        void mostrarNome()
        {
            string nome = textBox1.Text;
            MessageBox.Show("Ol� " + nome);
        }
        //Fun��o para converter dinheiro -- Com parametros --> Nessa fun��o ser� obrigado a 
        //Apresentar um label, logo, a fun��o n�o funciona sem label. Com isso, quem chamar
        //A fun��o ser� obrigado a usar um label.
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
            //Programando bot�o:Usando fun��es
            mostrarMensagem();


        }

        private void bntMensagem2_Click(object sender, EventArgs e)
        {
            //Assim, aparece mensagens sucessivas ap�s a primeira chamada
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