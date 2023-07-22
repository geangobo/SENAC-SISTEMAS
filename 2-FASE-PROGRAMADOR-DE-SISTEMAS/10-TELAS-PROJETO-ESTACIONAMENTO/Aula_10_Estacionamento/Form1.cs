using Aula8_Estoque;

namespace Aula_10_Estacionamento
{
    public partial class Form1 : Form
    {
        //Lista de placas
        List<string> listaPlacas = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        void atualizarInterface()
        {
            int quantPlacas = listaPlacas.Count;
            lblVeiculos.Text = quantPlacas.ToString();

            //Para apagar o que tem dentro do listView pois vai ser atualizado com a lista nova.
            lv1.Clear();

            

            //Percorrer a lista e adicionar dentro do listView
            foreach (var item in listaPlacas)
            {
                lv1.Items.Add(item);
            }

        }
        void deletarPlaca()
        {
            listaPlacas.Remove(txtPlaca.Text);



            atualizarInterface();



        }


        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void bntFechar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ESTACIONAMENTO FECHADO! ");

        }

        private void bntEstacionar_Click(object sender, EventArgs e)
        {
            if (listaPlacas.Count >= 5)
            {
                MessageBox.Show("ESTACIONAMENTO LOTADO! ");
                return;
            }

            string placa = txtPlaca.Text;
            listaPlacas.Add(placa);
            atualizarInterface();


            Utilidades utilidades = new Utilidades();
            utilidades.mostraMensagem();
        }

        private void lblVeiculos_Click(object sender, EventArgs e)
        {

        }

        private void bntRetirar_Click(object sender, EventArgs e)
        {
            deletarPlaca();
            Utilidades utilidades = new Utilidades();
            utilidades.mostraMensagem();

        }

        private void lv1_SelectedIndexChanged(object sender, EventArgs e)
        {
            atualizarInterface();
        }

        private void txtPlaca_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}