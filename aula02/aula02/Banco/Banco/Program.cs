using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente c1 = new ContaCorrente();

            c1.Titular = "Maria Aparecida dos santos";
            c1.saldo = 500;
            c1.Numero = 01002;
            c1.Agencia = 00;

            Console.ReadLine();
        }
    }
}
