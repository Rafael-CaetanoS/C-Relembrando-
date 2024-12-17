using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco.Clientes;

namespace Banco.Conta
{
    public class ContaHeranca : ContaCorrente
    {
        public ContaHeranca(double saldo, Cliente cliente) : base(saldo, cliente)
        {
        }

        public override void depositar(double valor)
        {
            base.saldo = this.saldo + valor + ( valor * 0.01);
        }
    }
}
