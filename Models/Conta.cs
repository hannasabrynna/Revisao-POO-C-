using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace BancoC_.Models
{
    public class Conta
    {
        // Propriedades da classe Conta
        public int NumeroConta { get; set; }
        private decimal Saldo;
        public bool StatusConta;

        //Constructor
        public Conta(int numeroConta, decimal saldo, bool status)
        {
            NumeroConta = numeroConta;
            Saldo = saldo;
            StatusConta = status;
        }

        // Metodos
        public void Sacar(decimal valor)
        {
            if (Saldo >= valor && StatusConta == true)
            {
                Saldo -= valor;
                Console.WriteLine("Saque no valor: R$" + valor + " foi relaizado com sucesso!!");
            }else{
                Console.WriteLine("Saque no valor: R$" + valor + " não pode ser efetuado!!");
            }
        }

        public void Depositar(decimal valor)
        {
            if (valor>0 && StatusConta == true)
            {
                Saldo += valor;
                Console.WriteLine("Deposito no valor: R$" + valor + " foi relaizado com sucesso!!");
            }else{
                Console.WriteLine("Deposito no valor: R$" + valor + " não pode ser efetuado !!");
            }
        }

        public void ExibirSaldo(){
            Console.WriteLine("Seu saldo é: R$" + Saldo);
        }


    }
}