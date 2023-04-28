namespace LancamentoDeExcecoes
{
    public class Triangulo
    {
        public double LadoA { get; set; }
        public double LadoB { get; set; }
        public double LadoC { get; set; }

        public Triangulo(double ladoA, double ladoB, double ladoC)
        {
            if (ladoA > ladoB + ladoC)
                throw new InvalidTriangleSideException('A');

            if (ladoB > ladoA + ladoC)
                throw new InvalidTriangleSideException('B');

            if (ladoC > ladoA + ladoB)
                throw new InvalidTriangleSideException('C');

            LadoA = ladoA;
            LadoB = ladoB;
            LadoC = ladoC;
        }

        public double Area()
        {
            double semiPerimetro = (LadoA + LadoB + LadoC) / 2;
            double area = Math.Sqrt(semiPerimetro *
                (semiPerimetro - LadoA) *
                (semiPerimetro - LadoB) *
                (semiPerimetro - LadoC)
            );
            return area;
        }
    }
}
