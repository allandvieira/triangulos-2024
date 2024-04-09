namespace Triangulos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o valor de X:");
            double X = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor de Y:");
            double Y = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor de Z:");
            double Z = double.Parse(Console.ReadLine());

            Triangulo triangulo = new Triangulo(X, Y, Z);

            if (triangulo.eValido())
            {
                Console.WriteLine(triangulo.TipoTriangulo());
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Os valores fornecidos não formam um triângulo.");
                Console.ReadLine();
            }
        }
    }
}
