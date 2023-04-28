namespace Pessoa
{
    public class Pessoa
    {
        private string cpf;
        public string Cpf
        {
            get { return cpf; }
            set
            {
                if (value.Length == 11 && value.HasOnlyDigits()) cpf = value;
                else throw new Exception("O CPF deve possuir 11 dígitos.");
            }
        }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public double IMC
        {
            get
            {
                return Peso / (Altura * Altura);
            }
        }

        public Pessoa(string nome, string sobrenome, DateTime dataNascimento, string cpf)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            DataNascimento = dataNascimento;
            Cpf = cpf;
        }

        public Pessoa(string nome, string sobrenome, DateTime dataNascimento, string cpf, double peso, double altura) : this(nome, sobrenome, dataNascimento, cpf)
        {
            Peso = peso;
            Altura = altura;
        }

        public void Comer(double pesoKg)
        {
            Peso += pesoKg / 10;
            Console.WriteLine($"{Nome} {Sobrenome} comeu {pesoKg}kg de comida.");
        }

        public void Comer(int calorias)
        {
            Peso += calorias / 30000;
            Console.WriteLine($"{Nome} {Sobrenome} ingeriu {calorias} calorias.");
        }

        public void Correr(double distanciaKm, int dias = 1)
        {
            Peso -= distanciaKm / 40 * dias;
            Console.WriteLine($"{Nome} {Sobrenome} correu {distanciaKm} kms diários por {dias} dia(s).");
        }

        public void MostrarDados()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"Nome completo: {Nome} {Sobrenome}");
            Console.WriteLine($"Idade: {Math.Truncate((DateTime.Now - DataNascimento).TotalDays / 365.25)} anos");
            Console.WriteLine($"IMC: {IMC:F2}");
        }
    }
}
