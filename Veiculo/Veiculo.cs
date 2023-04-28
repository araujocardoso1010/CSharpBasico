namespace Veiculo
{
    public abstract class Veiculo
    {
        public int PesoKg { get; set; }
        public DateTime DataFabricacao { get; set; }
        public double QuantidadeCombustivel { get; set; }
        public string Tipo { get { return GetType().Name; } }
        public abstract int Capacidade { get; set; }
        
        public abstract void Abastecer(double quantidadeLitros);

        public abstract void Mover(double distanciaKm);

        public virtual void Frear()
        {
            Console.WriteLine("Acionando freios... Parou!");
        }

        public Veiculo(int pesoKg, DateTime dataFabricacao)
        {
            PesoKg = pesoKg;
            DataFabricacao = dataFabricacao;
        }
    }
}
