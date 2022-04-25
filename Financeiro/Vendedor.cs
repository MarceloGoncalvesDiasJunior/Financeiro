using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financeiro
{
    public class Vendedor
    {

        public int IdVendedor { get; set; }
        public string Nome { get; set; }

        public Vendedor(int id, string nome)
        {
            IdVendedor = id;
            Nome = nome;
        }
    }
}
