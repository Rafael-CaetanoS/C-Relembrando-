using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco.Enderecos;


namespace Banco.Clientes
{
    public class Cliente
    {
        public String nome { get; set; } 
       
        private String cpf{ get; set; }

        public String Cpf
        {
            get
            {
                return cpf;
            }
            set {
                cpf = value; 
            } 
        }
        private Endereco endereco { get; set; }

        public Endereco Endereco {
            get { return endereco; }
            set { endereco = value; }
        }

        public Cliente() { }

        public Cliente(string nome, string cpf, Endereco endereco)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.endereco = endereco;
        }

        public String retortnar()
        {
            return $"{this.nome} {this.cpf} {this.endereco.rua} ";
        }

    }
}
