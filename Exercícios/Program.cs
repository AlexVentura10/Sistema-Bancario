using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercícios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dados cliente = new Dados("Alex Mateus", "2206");

           

            while (true)
            {
                Console.WriteLine("---Menu---");
                Console.WriteLine("1 - Saldo");
                Console.WriteLine("2 - Saque");
                Console.WriteLine("3 - Depósito");
                Console.WriteLine("4 - Sair");

                Console.WriteLine("Digite o número da sua opção");
                string opcao = Console.ReadLine();

                Console.Clear();    


                if (opcao == "1")
                {
                    Console.WriteLine("Informe sua senha");
                    string senha = Console.ReadLine();

                    Console.Clear();

                    cliente.mSaldo(senha);
                  
                }

                else if (opcao == "2") 
                {
                    
                    Console.WriteLine("Informe o valor do saque");
                    int saque = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Informe sua senha");
                    string senha = Console.ReadLine();

                    Console.Clear();

                    cliente.mSaque(senha, saque);
                }

                else if (opcao == "3") 
                {
                    Console.WriteLine("Informe o valor de depósito");
                    int valor = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Informe o nome dp cliente");
                    string nome = Console.ReadLine();

                    Console.Clear();

                    cliente.mDeposito(nome, valor);
                }

                else if (opcao == "4") 
                {
                    break;
                }

                else
                {
                    Console.WriteLine("Opção desconhecida.");
                }
            }

            

        }

      
    }
}
