using System;
using System.Collections.Generic;



namespace Financeiro
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //-------------Produtos--------
            Produtos p1 = new Produtos(1, "TV", 2000.00);
            Produtos p2 = new Produtos(2, "Geladeira", 2500.00);
            Produtos p3 = new Produtos(3, "Computador", 5000.00);
            Produtos p4 = new Produtos(4, "Celular", 3400.00);
            Produtos p5 = new Produtos(5, "Xbox", 6000.00);
            //-------------------------

            



            Console.Write("Digite o numero de quatidade: ");
            int index = int.Parse(Console.ReadLine());

            int[] lista = new int[index];
            Produtos[] carrinhos = new Produtos[index];

            List<Produtos> produtos = new List<Produtos>(index);
            produtos.Add(p1);
            produtos.Add(p2);
            produtos.Add(p3);
            produtos.Add(p4);
            produtos.Add(p5);

            produtos.CopyTo(carrinhos);
            //carrinhos = produtos.ToArray();

            Console.WriteLine("Carrinhos");
            foreach (var carrinho in carrinhos)
            {
                Console.WriteLine($"#{carrinho.IdProdutos} Produtos: {carrinho.NomeProduto}  R${carrinho.Valor}");
            }

            Console.WriteLine("Digite o nome do vendedor");
            string nome = Console.ReadLine();

            Vendedor vendedor = new Vendedor(1, nome);

            
            foreach(var produto in produtos)
            {
                Console.WriteLine($"#{produto.IdProdutos} Produtos: {produto.NomeProduto}  R${produto.Valor}");
            }

            Console.WriteLine("Quantidade de Produtos: " + produtos.Count);
            Console.WriteLine("Vendedor: " + vendedor.Nome);

        }
    }
}