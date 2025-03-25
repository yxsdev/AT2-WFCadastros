using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT2_WFCadastros
{
    public enum Status
    {
       Ativo = 1,
       Inativo
    }

    public class Categoria
    {
        public int Codigo { get; set; }
        public string? NomeCategoria { get; set; }
        public string? Descricao { get; set; }
        public DateTime DataCadastro { get; set; }
        public Status status { get; set; }

        public static
            List<Categoria> ListaProduto = new List<Categoria>();
    }
}
