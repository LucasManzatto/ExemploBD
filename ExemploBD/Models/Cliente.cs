using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExemploBD.Models
{
    public class Cliente
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Endereco_id { get; set; }

        public Cliente()
        {
        }

        public Cliente(string nome, string cpf, string rg, string endereco_id)
        {
            Nome = nome;
            Cpf = cpf;
            Rg = rg;
            Endereco_id = endereco_id;
        }
        public Cliente(int id, string nome, string cpf, string rg, string endereco_id)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Rg = rg;
            Endereco_id = endereco_id;
        }
 
    }
}