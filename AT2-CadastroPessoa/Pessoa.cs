using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT2_CadastroPessoa
{
    public enum ETipoTelefone
    {
        Pessoal = 1,
        Comercial,
        Recado
    }

    class Pessoa
    {
        public Pessoa(int codigo, string? cpf, string? 
            nomeCompleto, string? ddd, string? celular, 
            ETipoTelefone tipoTelefone, string? email, 
            string? possuiFilhos)
        {
            Codigo = codigo;
            Cpf = cpf;
            NomeCompleto = nomeCompleto;
            Ddd = ddd;
            Celular = celular;
            TipoTelefone = tipoTelefone;
            Email = email;
            PossuiFilhos = true;
        }

        public Pessoa() { }

        public static List<Pessoa> ListaPessoa =
            new List<Pessoa>();

        public int Codigo { get; set; }
        public string? Cpf { get; set; }
        public string? NomeCompleto { get; set; }
        public string? Ddd { get; set; }
        public string? Celular { get; set; }
        public ETipoTelefone TipoTelefone { get; set; }
        public string? Email { get; set; }
        public bool PossuiFilhos { get; set; }

    }
}
