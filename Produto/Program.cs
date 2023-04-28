namespace Produto
{
    public class Program
    {
        private static readonly List<Produto> produtos = new();

        static Program()
        {
            Console.WriteLine("Exemplo de construtor estático.");
            Console.ReadKey();
        }
        public static void Main()
        {
            string opcao;

            do
            {
                Console.Clear();
                Console.WriteLine("Escolha uma Opção:");
                Console.WriteLine("1 - Cadastrar produto");
                Console.WriteLine("2 - Listar produto");
                Console.WriteLine("S - Sair\n");

                Console.Write("Opção desejada: ");
                opcao = Console.ReadKey().KeyChar.ToString().ToUpper();

                switch (opcao)
                {
                    case "1":
                        Console.Write("\n\nNome do produto: ");
                        string nome = Console.ReadLine();
                        Console.Write("Preço do produto: ");
                        double preco = Convert.ToDouble(Console.ReadLine());
                        produtos.Add(new(nome, preco));
                        Console.WriteLine("\nProduto criado com sucesso!");
                        Console.ReadKey();
                        break;
                    case "2":
                        if (produtos.Count > 0)
                        {
                            Console.WriteLine("\n\nListagem de produtos:");
                            foreach (Produto p in produtos)
                            {
                                Console.WriteLine(p.Descricao());
                            }
                            Console.Write("Pressione qualquer tecla para prosseguir...");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("\n\nNão há produtos cadastrados. ");
                            Console.ReadKey();
                        }
                        break;
                    case "S":
                        Console.WriteLine("\n\nObrigado por usar o programa.");
                        break;
                    default:
                        Console.WriteLine("\n\nOpção inválida! Tente novamente.");
                        Console.ReadKey();
                        break;
                }
            } while (opcao != "S");
        }
    }
}