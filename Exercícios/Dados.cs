using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercícios
{
    internal class Dados
    {

        //atributos 
        private string cliente;
        private string senha;
        private int saldo;

        //propriedades

        public string Cliente
        { 
            get { return cliente; } 
            set {  cliente = value; } 
        }

        public string Senha
        { 
            get { return senha; } 
            set { senha = value; } 
        }    

        public int Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        //métodos

        public void mSaldo(string pSenha)
        {
            if (senha==pSenha)
            {
                Console.WriteLine($"Seu saldo é: {Saldo.ToString("c")}");
            }
            else 
            {
                Console.WriteLine("Senha incorreta.");
            }
        }


        public int mSaque(string pSenha, int pValor)
        {
            if (senha==pSenha)
            {
                if(Saldo >=pValor)
                {
                    Console.WriteLine($"Saque realizado com sucesso.");
                    Console.WriteLine($"Valor: {pValor.ToString("c")}");
                    saldo -=pValor;
                    return pValor;
                }
                else 
                {
                    Console.WriteLine("Saldo insuficiente.");
                    return 0;
                }
            }
            else
            {
                Console.WriteLine("Senha incorreta.");
                return 0;
            }
        }


        public int mDeposito(string pCliente, int pDeposito)
        {
            if (Cliente==pCliente)
            {
                Console.WriteLine("Depósito realizado com sucesso.");
                saldo += pDeposito;
                return pDeposito;
            }
            else
            {
                Console.WriteLine("Cliente não localizado.");
                return 0;
            }
        }


        //construtor
        public Dados (string pcliente, string pSenha)
        {        
            cliente = pcliente;
            senha = pSenha;
            saldo = 0;
        }

    }
}
