using System.Text;

namespace Produto
{
    public class Produto
    {
        public string nome;
        public double Preco { get; set; }
        public int Estoque { get; private set; }
        public string Nome
        {
            get { return nome; }
            set
            {
                if (value.Length > 1) nome = value;
                else throw new Exception("O nome do produto deve ter pelomenos 2 caracteres.");
            }
        }

        public Produto()
        {
            Estoque = 0;
        }

        public Produto(string nome, double preco) : this()
        {
            Nome = nome;
            Preco = preco;
        }

        public int Vender(int qtd)
        {
            if (Estoque - qtd >= 0) Estoque -= qtd;
            return Estoque;
        }

        public int Comprar(int qtd)
        {
            Estoque += qtd;
            return Estoque;
        }

        public string Descricao()
        {
            StringBuilder sb = new();
            sb.Append($"Nome: {Nome}\n");
            sb.Append($"Preço: {Preco}\n");
            sb.Append($"Estoque: {Estoque}\n");
            return sb.ToString();
        }
    }
}
