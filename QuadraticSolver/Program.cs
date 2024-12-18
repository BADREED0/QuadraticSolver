using System;

namespace QuadraticSolver
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Résolution de l'équation quadratique ax^2 + bx + c = 0");
            Console.Write("Entrez a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Entrez b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Entrez c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            try
            {
                var solutions = Solve(a, b, c);
                Console.WriteLine("Les solutions sont :");
                Console.WriteLine($"x1 = {solutions.Item1}");
                Console.WriteLine($"x2 = {solutions.Item2}");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static Tuple<double?, double?> Solve(double a, double b, double c)
        {
            if (a == 0)
                throw new ArgumentException("Le coefficient a ne peut pas être nul pour une équation quadratique.");

            double discriminant = b * b - 4 * a * c;

            if (discriminant > 0)
            {
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                return Tuple.Create<double?, double?>(x1, x2);
            }
            else if (discriminant == 0)
            {
                double x = -b / (2 * a);
                return Tuple.Create<double?, double?>(x, null);
            }
            else
            {
                return Tuple.Create<double?, double?>(null, null);
            }
        }
    }
}
