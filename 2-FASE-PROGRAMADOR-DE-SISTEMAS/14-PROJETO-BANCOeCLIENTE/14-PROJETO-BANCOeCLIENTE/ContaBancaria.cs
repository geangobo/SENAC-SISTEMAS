using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _14_PROJETO_BANCOeCLIENTE
{
    internal class ContaBancaria
    {
        //Atributos
        public double saldo;
        public bool credito = true;
        public bool debito = true;
        

        public ContaBancaria(double saldo, bool credito, bool debito)
        {
            this.saldo = saldo;
            this.credito = credito;
            this.debito = debito;
            
        }
        public void mostrar2()
        {
            Console.WriteLine($"Saldo: {saldo}, Crédito: {credito}, Débito: {debito}");
        }

    }
}
