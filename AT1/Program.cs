namespace AT1
{
    public delegate int Calcular(int x, int y);
    internal class Program
    {
        public static int Somar(int x, int y)
        {
            return x + y;
        }

        public static int Subtrair(int x, int y)
        {
            return x - y;
        }

        public static int Multiplicar(int x, int y)
        {
            return x * y;
        }

        static void Main(string[] args)
        {
            Calcular calcularSoma = new Calcular(Somar);
            Calcular calcularSubtracao = new Calcular(Subtrair);
            Calcular calcularMulti = new Calcular(Multiplicar);

            Console.WriteLine("Digite dois números inteiros: ");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a operação que deseja realizar:");
            Console.WriteLine("[1] - Somar");
            Console.WriteLine("[2] - Subtrair");
            Console.WriteLine("[3] - Multiplicar");
            int op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.WriteLine("Resultado: " + calcularSoma(x, y));
                    break;
                case 2:
                    Console.WriteLine("Resultado: " + calcularSubtracao(x, y));
                    break;
                case 3:
                    Console.WriteLine("Resultado: " + calcularMulti(x, y));
                    break;
            }
        }
    }
}
