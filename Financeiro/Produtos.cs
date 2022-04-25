using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financeiro
{
    public class Produtos
    {
        public int IdProdutos { get; set; }

        public string NomeProduto { get; set; }

        public double Valor { get; set; }

        public Produtos()
        {

        }

        public Produtos(int id, string nomeProduto, double valor)
        {
            IdProdutos = id;
            NomeProduto = nomeProduto;
            Valor = valor;
        }

        public void SomaDasVendas(Produtos produtos)
        {
            produtos.Valor = Valor;
        }
    }
}
