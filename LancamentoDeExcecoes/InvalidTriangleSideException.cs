namespace LancamentoDeExcecoes
{
    public class InvalidTriangleSideException : Exception
    {
        const string mensagemErro = "Um dos lados do triângulo excede o tamanho máximo permitido";

        public char LadoErrado { get; }

        public InvalidTriangleSideException(char ladoErrado) : base(mensagemErro)
        {
            HelpLink = @"http://www.stoodi.com.br/blog/matematica/triangulo/";
            LadoErrado = ladoErrado;
        }
    }
}
