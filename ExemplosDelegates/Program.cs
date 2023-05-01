namespace ExemplosDelegates
{
    public class Program
    {
        public delegate double Operacao(double x, double y);

        public static double Somar(double x, double y)
        {
            Console.WriteLine( $"{x} + {y} = {x + y}");
            return x + y;
        }

        public static double Multiplicar(double x, double y)
        {
            Console.WriteLine($"{x} x {y} = {x * y}");
            return x * y;
        }

        public static double Elevar(double x, double y)
        {
            Console.WriteLine($"{x} ^ {y} = {Math.Pow(x, y)}");
            return Math.Pow( x, y );
        }

        static void Main()
        {
            /*List<Operacao> operacoes = new()
            {
                new Operacao(Somar),
                new Operacao(Multiplicar),
                new Operacao(Elevar),

                // função anônima
                delegate (double a, double b)
                {
                    if(b != 0)
                    {
                        Console.WriteLine($"{a} / {b} = {a / b:F2}");
                        return a / b;
                    }
                    else
                    {
                        Console.WriteLine($"{a} / {b} = impossível dividir por zero");
                        return 0;
                    }
                }
            };

            foreach(var op in operacoes)
            {
                op(9, 0);
                op(9, 1);
                op(9, 2);
                op(9, 3);
                op(9, 4);
                op(9, 5);
                op(9, 6);
                op(9, 7);
                op(9, 8);
                op(9, 9);
                Console.WriteLine();
            }*/

            // Multicast
            Operacao multicast = Somar;
            multicast += Multiplicar;
            multicast += Elevar;
            multicast += delegate (double a, double b)
            {
                if (b != 0)
                {
                    Console.WriteLine($"{a} / {b} = {a / b:F2}");
                    return a / b;
                }
                else
                {
                    Console.WriteLine($"{a} / {b} = impossível dividir por zero");
                    return 0;
                }
            };

            multicast(20, 5);
        }
    }
}