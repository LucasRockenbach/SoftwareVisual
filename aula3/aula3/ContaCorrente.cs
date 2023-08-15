using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula3
{
    class ContaCorrente
    {
        public Cliente titular;
        public string agencia;
        public int numero;
        public double saldo;

        public bool Sacar(double valor)
        {
            if(this.saldo > 0 && this.saldo < valor)
            {
                return false;
            }
            else
            {
                this.saldo -= valor;
                return true;
            }
            
        }

        public bool Despositar(double valor)
        {
            this.saldo += valor;
            return true;

        }

        public bool Pix (double valor, ContaCorrente contaCorrente)
        {
            if(Sacar(valor) && contaCorrente != null)
            {
                return contaCorrente.Despositar(valor);
                
            }
            return false;
        }



    }
}
