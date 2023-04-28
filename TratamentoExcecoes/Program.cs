namespace TratamentoExcecoes
{
    internal class Program
    {
        // Alguns tipos de Exceções
        // DivideByZeroException
        // IndexOutOfRangeException
        // NullReferenceException
        // InvalidCastException
        // FormatException
        // ArgumentNullException
        // FileNotFoundException
        // DirectoryNotFoundException
        // PathTooLongException
        // UnauthorizedAccessException
        // IOException

        static void Main()
        {
            ConverterObjetoParaInteiro("123");

            Console.WriteLine("Fim do Programa");
        }

        static void ConverterObjetoParaInteiro(object obj)
        {
            try
            {
                //Console.WriteLine(Convert.ToInt32(obj)); // FormatException
                Console.WriteLine((int) obj); // InvalidCastException
            }
            catch (Exception e)
            {
                if(e is FormatException || e is InvalidCastException)
                    Console.WriteLine("O objeto passado por parâmetro não pôde ser convertido para inteiro."); 
            }
        }

        static void ConverterObjetoParaInteiroSemTratamento(object obj)
        {
            Console.WriteLine((int)obj);
        }
    }
}