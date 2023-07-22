namespace Aula_6_streaming
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            //Your name
            string titulo = "Your Name";
            string desc = "Um filme de animação japonesa que acompanha a vida de dois adolescentes, um rapaz da cidade \r\ne uma garota do campo, que misteriosamente começam a trocar de corpos durante o sono. Enquanto tentam \r\nentender essa conexão inexplicável, eles embarcam em uma jornada emocional que desafia o tempo e a distância";
            string img_caminho = "C:/Users/DELL/source/repos/Aula_6_streaming/Aula_6_streaming/imagens/your_name_edit.png";
            string link_video = "https://www.youtube.com/embed/ayi6VfCKBcA";

            Form2 TelaInfo = new Form2();
            TelaInfo.img_caminho = img_caminho;
            TelaInfo.titulo = titulo;
            TelaInfo.descricao = desc;
            TelaInfo.link_video = link_video;
            TelaInfo.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            //Mariguela
            tring titulo2 = "Marighela";
            string desc1 = " Um filme que retrata a vida de Carlos Marighela, um guerrilheiro e líder revolucionário brasileiro. \r\nA história mostra sua luta contra a ditadura militar no Brasil, suas estratégias de guerrilha urbana e seus ideais \r\nde resistência e liberdade. O filme oferece uma visão inspiradora da coragem e determinação de Marighela em busca de justiça e mudança.\r\n";
            string img_caminho1 = "C:/Users/DELL/source/repos/Aula_6_streaming/Aula_6_streaming/imagens/mari_edit.png";
            string link_video1 = "https://www.youtube.com/embed/fd8oX1u8gRA";

            Form2 TelaInfo = new Form2();
            TelaInfo.img_caminho1 = img_caminho1; 




        }
    }
}