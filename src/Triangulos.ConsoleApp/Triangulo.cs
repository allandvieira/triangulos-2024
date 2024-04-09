using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulos.ConsoleApp
{
    internal class Triangulo
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Triangulo(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public bool eValido()
        {
            if (X < Y + Z && Y < X + Z && Z < X + Y)
                return true;
            else
                return false;
        }

        public string TipoTriangulo()
        {
            if (!eValido())
                return "Os valores fornecidos não formam um triângulo.";
            else if (X == Y && Y == Z)
                return "O triângulo é equilátero.";
            else if (X == Y || Y == Z || Z == X)
                return "O triângulo é isósceles.";
            else
                return "O triângulo é escaleno.";
        }
    }
}
