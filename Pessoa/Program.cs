namespace Pessoa
{
    public class Program
    {
        static void Main()
        {
            Pessoa p1 = new("Albert", "Einstein", new DateTime(1955, 6, 17), "98765432101")
            {
                Peso = 76,
                Altura = 1.78
            };

            p1.MostrarDados();
            p1.Comer(2.5);
            p1.Comer(3800);
            p1.Correr(7, 30);
            p1.MostrarDados();

            Pessoa p2 = new("Ada", "Lovelace", new DateTime(1977, 4, 18), "32165498778", 62, 1.65);
            p2.MostrarDados();
        }
    }
}