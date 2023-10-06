using System;

class Investimento
{
    public double ValorInvestido { get; set; }
    public double TaxaDeJuros { get; set; }
    public int NumeroPeriodosMes { get; set; }

    public double CalcularRendimentoFuturo()
    {
        double taxaDecimal = TaxaDeJuros / 100;

        double rendimento = ValorInvestido * Math.Pow(1 + taxaDecimal, NumeroPeriodosMes);

        return rendimento;
    }
}

class Program
{
    static void Main()
    {
        Investimento investimento1 = new Investimento
        {
            ValorInvestido = 1000,
            TaxaDeJuros = 3,
            NumeroPeriodosMes = 8
        };

        Investimento investimento2 = new Investimento
        {
            ValorInvestido = 5500,
            TaxaDeJuros = 2.48,
            NumeroPeriodosMes = 8
        };

        Investimento investimento3 = new Investimento
        {
            ValorInvestido = 12000,
            TaxaDeJuros = 2,
            NumeroPeriodosMes = 8
        };

        Console.WriteLine("Investimento 1 - Rendimento Futuro: $" + investimento1.CalcularRendimentoFuturo());
        Console.WriteLine("Investimento 2 - Rendimento Futuro: $" + investimento2.CalcularRendimentoFuturo());
        Console.WriteLine("Investimento 3 - Rendimento Futuro: $" + investimento3.CalcularRendimentoFuturo());
    }
}
