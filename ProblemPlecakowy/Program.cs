    using System.Runtime.CompilerServices;

    [assembly:InternalsVisibleTo("TestProject1"), InternalsVisibleTo("WinFormsApp1")]

    namespace ProblemPlecakowy
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Wpisz liczbe przedmiotow: ");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("Wpisz seed");
                int seed = int.Parse(Console.ReadLine());
                Problem problem = new Problem(n, seed);
                Console.WriteLine("Wpisz pojemnosc plecaka");
                int c = int.Parse(Console.ReadLine());
                Result result = problem.Solve(c);
                Console.Write(problem.ToString());
                Console.WriteLine();
                Console.Write(result.ToString());
            }
        }
    }
