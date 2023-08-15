using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula3
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            Console.WriteLine("digite o nome do cliente");
            cliente.nome = Console.ReadLine();
            Console.WriteLine("digite o cpf do cliente");
            cliente.cpf = Console.ReadLine();
            Console.WriteLine("digite o email do cliente");
            cliente.email = Console.ReadLine();

            ContaCorrente c1 = new ContaCorrente();
            Console.WriteLine("digite o saldo inicial da conta");
            c1.saldo = double.Parse(Console.ReadLine());
            c1.numero = 001;
            c1.titular = cliente;
            c1.agencia = "04";

            c1.Sacar(500);
            c1.Despositar(1000);

            Console.WriteLine("cliente: " + cliente.nome + " tem saldo:" + c1.saldo);
 

            // conta 2 

            Cliente cliente2 = new Cliente();
            Console.WriteLine("digite o nome do cliente");
            cliente2.nome = Console.ReadLine();
            Console.WriteLine("digite o cpf do cliente");
            cliente2.cpf = Console.ReadLine();
            Console.WriteLine("digite o email do cliente");
            cliente2.email = Console.ReadLine();

            ContaCorrente c2 = new ContaCorrente();
            Console.WriteLine("digite o saldo inicial da conta");
            c2.saldo = double.Parse(Console.ReadLine());
            c2.numero = 001;
            c2.titular = cliente;
            c2.agencia = "04";

            // testando o pix 

            Console.WriteLine("digite o valor que sera transferido" + " do cliente " + c1.titular.nome + "para o cliente: " + 
                c2.titular.nome);
            double valor = double.Parse(Console.ReadLine());

            if(c1.Pix(valor, c2))
            {
                Console.WriteLine("pix realizado com sucesso");
            }

            Console.ReadLine();
        }
    }
}
