using System;

class Program
{
    static void Main()
    {
        Console.Write("Informe o valor presente: ");
        string inputValorPresente = Console.ReadLine();

        Console.Write("Informe a taxa de juros (%): ");
        string inputTaxaJuros = Console.ReadLine();

        Console.Write("Informe o período (anos): ");
        string inputPeriodoAnos = Console.ReadLine();

        if (!string.IsNullOrEmpty(inputValorPresente) && !string.IsNullOrEmpty(inputTaxaJuros) && !string.IsNullOrEmpty(inputPeriodoAnos))

        {
            decimal valorPresente = decimal.Parse(inputValorPresente);
            decimal taxaJuros = decimal.Parse(inputTaxaJuros) / 100;
            int periodoAnos = int.Parse(inputPeriodoAnos);

            decimal valorFuturo = valorPresente * (decimal)Math.Pow(1 + (double)taxaJuros, periodoAnos);

            Console.WriteLine($"Valor Futuro após {periodoAnos} anos: R$ {valorFuturo:F2}");
        }
        else
        {
            Console.WriteLine("Entradas inválidas. Certifique-se de inserir valores válidos.");
        }
    }
}
