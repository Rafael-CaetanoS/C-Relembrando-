using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco.Clientes;

namespace Banco.Conta
{
    public class ContaCorrente
    {
        public static int numeroDecontas = 0;

        public int numeroAgencia { get { return 1111; } }
        private double _saldo;

        public double saldo { get { return _saldo; } set { _saldo = value; } }

        public Cliente cliente;

        public ContaCorrente(double saldo, Cliente cliente)
        {
            _saldo = saldo;
            this.cliente = cliente;
            numeroDecontas++;
        }

        public virtual void depositar(double valor)
        {
            this.saldo += valor;
        }

        public void sacar(double valor)
        {
            if (valor > saldo)
            {
                Console.WriteLine("Saldo insuficiente");
            }
            else {this.saldo -= valor; }
        }

        public void transferir(double valor, ContaCorrente destino)
        {
            if(valor > saldo)
            {
                Console.WriteLine("Saldo insuficinete");
            }
            else
            {
                this.saldo -= valor;
                destino.depositar(valor);
                Console.WriteLine($"Transferio R${valor} para o/a {destino.cliente.nome}");
            }
        }
        public double vizualizarSaldo()
        {
            return saldo;
        }

        public void teste(ref int teste)
        {
            teste += 10;
        }
    }
}
