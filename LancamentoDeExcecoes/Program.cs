namespace LancamentoDeExcecoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Triangulo t = new(30, 12, 12);

                Console.WriteLine($"Área do triângulo: {t.Area():F2}");
            }
            catch(InvalidTriangleSideException e)
            {
                Console.WriteLine($"Mensagem: {e.Message}\n");
                Console.WriteLine($"Lado inválido: {e.LadoErrado}\n");
                Console.WriteLine($"Saiba mais: {e.HelpLink}\n");
            }
        }
    }
}