using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Enderecos
{
    public class Endereco
    {
        public String rua { get; set; } 
        
        public String numero { get; set; }

        public String bairro { get; set; }

        public String cidade {  get; set; } 
        public String cep { get; set; } 
        public String estado {  get; set; } 

        public Endereco(String rua, String numero, String bairro, String cidade, String cep, String estado)
        {
            this.rua = rua;
            this.numero = numero;
            this.bairro = bairro;
            this.cidade = cidade;
            this.cep = cep;
            this.estado = estado;
        }

        public Endereco() { }   

    }
}
