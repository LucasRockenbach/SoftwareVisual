using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula02
{
    class Program
    {
        static void Main(string[] args)
        {

            /* receber uma idade e acompanhante (bool)
             * so entra maior de 18 acompanhado



            Console.WriteLine("digite idade ");

            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("esta acompanhado? \n digite true para sim e false para não");
            bool acompanhado = bool.Parse(Console.ReadLine());

            if (idade >= 18 && acompanhado == true)
            {
                Console.WriteLine("voce pode entrar");

            }
            else
            {

                Console.WriteLine("voce não pode entrar");
            }

                ATIVIDADE 2 SAQUE DO BANCO 
             Console.WriteLine("digite o valor do saque");
        double saque = double.Parse(Console.ReadLine());

        int[] notas = new int[] { 100, 50, 20, 10, 50, 2 };

        for(int i = 0; i<notas.Length; i++)
        {
            int qtdnotas = (int)saque / notas[i]; // colocar o (int) porque é a divisao do um double por um int e voce perde as casas decimais 
            saque = saque - qtdnotas*notas[i];
            Console.WriteLine("Notas de " + notas[i] + ": " + qtdnotas);
        }


             ATIVIDADE 2


            Console.WriteLine("digite o numero da tabuada que voce quer");
            int i = 1;

            while(i < 100)
            {
                
                
                if (3 % i == 0)
                {
                    Console.WriteLine("o numero: " + i + " é divisivel por 3");
                    
                }
                i++;
                
            }
            
             
            ATIVIDADE 3 

            Console.WriteLine("digite um numero para ver a sua tabuada");

            int numero = int.Parse(Console.ReadLine());

            for(int i = 0; i<10; i++)
            {
                Console.WriteLine(numero + " x " + i + " = " + numero * i);
            }


            */




            Console.ReadLine();
        }
    }
}
