using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula8_Estoque
{
    internal class Utilidades
    {
        public void mostraMensagem()
        {
            MessageBox.Show("Olá você me chamou! ");
        }
        public bool textBoxVazio(TextBox txt)
        {
            if (txt.Text == "") //Para ver se o textBox está vario e não quebrar o código, apenas retornar uma mensagem
            {                   //Vou colocar na adicionar produto desse projeto. 
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}
