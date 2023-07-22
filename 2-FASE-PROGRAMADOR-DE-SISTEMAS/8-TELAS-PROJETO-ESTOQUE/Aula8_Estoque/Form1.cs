namespace Aula8_Estoque
{
    public partial class Form1 : Form
    {
        List<string> produtosNome = new List<string>();
        List<int> produtoQuantidade = new List<int>();
        //Tornando como global para evitar ter que chamar toda hora. 
        Utilidades utilidades = new Utilidades();
        
        public Form1()
        {
            InitializeComponent();
        }
        //Aqui ficará as funções globais
        //Função para adicionar produtos dentro do estoque 
        void adicionaProduto()
        {
            if(utilidades.textBoxVazio(txtNome) == true)
            {
                MessageBox.Show("O nome está vazio! ");
            }
            if (utilidades.textBoxVazio(txtQuantidade) == true)
            {
                MessageBox.Show("A quantidade de produto está vazio! ");
            }
            
            //Declarando variáveis
            string nome = txtNome.Text;
            int quantidade = int.Parse(txtQuantidade.Text);

            //Adicionando coisas dentro da lista, para fazer a função adicinar as coisas na lista.
            produtosNome.Add(nome);
            produtoQuantidade.Add(quantidade);
        }

        void atualizaInterface()
        {
            int quantidadeCadastrada = produtosNome.Count();
            lblCadastrados.Text = quantidadeCadastrada.ToString(); //Esse numero deve ser convertido em texto
            int quantidadeEstoque = produtoQuantidade.Sum(); //Sum usado para fazer uma somatória de cada elemento da lista.
            lblQuantidade.Text = quantidadeEstoque.ToString();

            //Com for: quantidade estoque
            //For --> var controladora (int i = 0); condição; inclementar contador (cada vez que percorre i adiciona 1)
            //int estoque = 0;
            //for (int i = 0; i < produtoQuantidade.Count; i++)
            // {
            //  int quantidade = produtoQuantidade[i];
            //   estoque += quantidade;
            // }

            //Usando o FOR é melhor pois aprendemos aplicar em quase qualquer coisa. Porém, você descobriu um jeito mais rápido (duas linhas).

        }

        void limpaCampos()
        {
            txtNome.Clear();
            txtQuantidade.Clear();
            txtNome.Focus();
        }

        void verProduto(bool primeiro)
        {
            string nome;
            int quantidade;

            if (primeiro == true)
            {
                nome = produtosNome[0];
                quantidade = produtoQuantidade[0];

            }
            else
            {
                nome = produtosNome[produtosNome.Count() - 1];
                quantidade = produtoQuantidade[produtoQuantidade.Count() - 1];
            }

            MessageBox.Show($"Nome: {nome}, quantidade: {quantidade}");
        }

        void deletaProduto()
        {
            produtoQuantidade.RemoveAt(0);
            produtosNome.RemoveAt(0);
            atualizaInterface();
        }

        void quantidadeEstoque()
        {
            produtoQuantidade.Count();
        }

        //Fazendo uma função com retorno: 
        bool listaVazia()
        {
            if (produtosNome.Count() > 0)
            {
                return false;
            }
            else
            {
                //Lista está vazia. 
                return true;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Vou ter que ter uma lista para nome e outra para quantidade, desse modo,
            //vou ter que mesclar a posição delas até mesmo para por conteúdo.
            //Essas listas serão globais

            adicionaProduto();

            atualizaInterface();


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpaCampos();
        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            verProduto(true);

        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            verProduto(false);
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            //Função deletar produto
            deletaProduto();
        }

        private void lblQuantidade_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Utilidades utilidades = new Utilidades();
            utilidades.mostraMensagem(); //Onde a função mostrarMensagem() está dentro do Utilidades que foi criado por fora e chamado como instância da classe. 

        }
    }
}