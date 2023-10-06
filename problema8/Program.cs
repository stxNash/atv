using System;

class ContaInvestimento
{
    private double valorInvestido;
    private double taxaJuros;
    private double resgate;

    public ContaInvestimento(double valorInvestido, double taxaJuros, double resgate)
    {
        this.valorInvestido = valorInvestido;
        this.taxaJuros = taxaJuros;
        this.resgate = resgate;
    }

    public double CalcularRendimento()
    {
        return valorInvestido * taxaJuros;
    }

    public double CalcularSaldoLiquido()
    {
        return valorInvestido + CalcularRendimento() - resgate;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Valor Investido: ");
        double valorInvestido = Convert.ToDouble(Console.ReadLine());

        Console.Write("Taxa de Juros (em decimal): ");
        double taxaJuros = Convert.ToDouble(Console.ReadLine());

        Console.Write("Resgate: ");
        double resgate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Período (em meses): ");
        int periodo = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nTabela de Dados Calculados:\n");
        Console.WriteLine("{0,-15} {1,-15} {2,-15} {3,-15} {4,-15} {5,-15}", "Mês", "Rendimento", "Saldo Anterior", "Resgate", "Saldo Líquido", "Período (a.m.)");

        ContaInvestimento conta = new ContaInvestimento(valorInvestido, taxaJuros, resgate);

        for (int mes = 1; mes <= periodo; mes++)
        {
            double rendimento = conta.CalcularRendimento();
            double saldoAnterior = conta.CalcularSaldoLiquido() + resgate;
            double saldoLiquido = conta.CalcularSaldoLiquido();

            Console.WriteLine("{0,-15} {1,-15:C2} {2,-15:C2} {3,-15:C2} {4,-15:C2} {5,-15:C2}", mes, rendimento, saldoAnterior, resgate, saldoLiquido, taxaJuros);

            if (mes < periodo)
            {
                conta = new ContaInvestimento(saldoLiquido, taxaJuros, resgate);
            }
        }
    }
}
