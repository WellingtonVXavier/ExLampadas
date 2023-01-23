using System;
using System.Data;
using System.Globalization;

namespace ExLampadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a pôtencia da lâmpada a ultilizar (Watts): ");
            double pontencia = double.Parse(Console.ReadLine());

            Console.Write("Informe o comprimento do cômodo (Metros): ");
            double comprimento = double.Parse(Console.ReadLine());

            Console.Write("Informe a largura do cômodo (Metros): ");
            double largura = double.Parse(Console.ReadLine());

            double metroQuadrado = Math.Round(largura * comprimento);

            double QtdLampadas = (metroQuadrado * 18) / pontencia;

            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Para iluminar um cômodo de "
                + Convert.ToDecimal(metroQuadrado).ToString("F2", CultureInfo.InvariantCulture)
                + " M²"
                + ", são necessárias "
                + Math.Ceiling(QtdLampadas)
                + " lâmpada(s) de "
                + pontencia
                + " Watts");

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}