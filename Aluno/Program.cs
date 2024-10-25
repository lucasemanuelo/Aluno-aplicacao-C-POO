using System;
using System.Globalization;

namespace Aluno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();

            Console.WriteLine("Nome do aluno:");
            Console.WriteLine("Digite as três notas do aluno:");
            a.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Nota final: " + a.Soma().ToString("F2", CultureInfo.InvariantCulture));
            if (a.Aprovado())
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
                Console.WriteLine("Faltaram " + a.NotaRestante().ToString("F2", CultureInfo.InvariantCulture) + " Pontos");
            }
        }
    }
}