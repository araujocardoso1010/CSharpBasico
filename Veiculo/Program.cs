namespace Veiculo
{
    internal class Program
    {
        static readonly List<Veiculo> veiculos = new();
        static readonly Random random = new();

        static void CriarVeiculosAleatorios()
        {
            for (int i = 0; i < 5; i++)
            {
                if (random.Next() % 2 == 0)
                    veiculos.Add(new Carro(random.Next(800, 1499), DateTime.Now.Date.AddDays(-random.Next(30, 3600))));
                else
                    veiculos.Add(new Onibus(random.Next(3000, 12000), DateTime.Now.Date.AddDays(-random.Next(30, 3600))));
            }
        }

        static void Main()
        {
            // Observar a diferença de declaração quando usar o método Frear()
            Veiculo v1 = new Onibus(6000, DateTime.Now.Date.AddDays(-5800));
            Onibus v2 = new(6000, DateTime.Now.Date.AddDays(-6000));

            // diferença entre override e new
            v1.Frear();
            v2.Frear();

            // alternativas
            ((Onibus)v1).Frear();

             if (v1 is Onibus) (v1 as Onibus).Frear(); // conversão segura
            
            Console.WriteLine();

            CriarVeiculosAleatorios();

            foreach(var v in veiculos)
            {
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine(v.Tipo);
                v.Abastecer(random.Next(10, 60));
                v.Mover(random.Next(10, 200));
                v.Frear();
            }
        }
    }
}
