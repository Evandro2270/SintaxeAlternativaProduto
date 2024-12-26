using System;
using System.Globalization;
using VendasPodutos;
namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                CultureInfo CI = CultureInfo.InvariantCulture;

                Console.WriteLine("Entre os dados do produto: ");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Preço: ");
                double preco = double.Parse(Console.ReadLine(), CI);
                Console.Write("Quantidade: ");
                int quantidade = int.Parse(Console.ReadLine());

                Produto p = new Produto(nome, preco, quantidade);
                Produto p2 = new Produto();
                Produto p3 = new Produto
                {
                    Nome = "TV",
                    Preco = 500.00,
                    Quantidade = 20
                };

                Console.WriteLine();
                Console.WriteLine("Dados do produto: " + p);

                Console.WriteLine();
                Console.Write("Digite o numero de produto a ser adicionado no estoque: ");
                int qte = int.Parse(Console.ReadLine());
                p.AdicionarProdutos(qte);

                Console.WriteLine();
                Console.WriteLine("Dados do produto Atualizados: " + p);

                Console.WriteLine();
                Console.WriteLine("Digite o numero de produto a ser removido no estoque: ");
                qte = int.Parse(Console.ReadLine());
                p.RemoverProdutos(qte);
                Console.WriteLine("Dados do produto Atualizados: " + p);

            }
        }
    }
}