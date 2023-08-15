using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula3
{
    class ClientePj : Cliente
    {
        private string Cnpj { get; set; }
        private string RazaoSocial { get; set; }

        public ClientePj(string nome, string email) : base(nome, email)
        {

        }

        public ClientePj(string nome, string email, string Cnpj, string RazaoSocial) : base(nome, email)
        {
            Cnpj = Cnpj;
            RazaoSocial = RazaoSocial;
        }

        // virtual diz que voce esta sobreescrevendo um metodo 
        public virtual string GerarRelatorio()
        {
            return this.Nome + " " + this.Email;
        }
        
    }
}
