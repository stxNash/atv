using System;

class ContaInvestimento
{
    private double valorPresente;
    private double taxaJuros;
    private int numeroPeriodos;
    private double resgateRendimento;

    public ContaInvestimento(double valorPresente, double taxaJuros, int numeroPeriodos, double resgateRendimento)
    {
        this.valorPresente = valorPresente;
        this.taxaJuros = taxaJuros;
        this.numeroPeriodos = numeroPeriodos;
        this.resgateRendimento = resgateRendimento;
    }

    public double CalcularSaldoNoMes(int mes)
    {
        double saldo = valorPresente;

        for (int i = 1; i <= mes; i++)
        {
            saldo += saldo * (taxaJuros / 100);
        }

        return saldo;
    }

    public double CalcularRendimentoNoMes(int mes)
    {
        double saldoNoMes = CalcularSaldoNoMes(mes);
        double rendimento = saldoNoMes - valorPresente;
        return rendimento;
    }

    public bool PodeResgatarNoMes(int mes)
    {
        if (mes >= 5)
        {
            double rendimentoAteMes4 = CalcularRendimentoNoMes(4);
            double saldoNoMes5 = CalcularSaldoNoMes(5);
            return (saldoNoMes5 - rendimentoAteMes4) >= resgateRendimento;
        }
        else
        {
            return false;
        }
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Valor Presente Investido: ");
        double valorPresente = Convert.ToDouble(Console.ReadLine());

        Console.Write("Taxa de Juros (%): ");
        double taxaJuros = Convert.ToDouble(Console.ReadLine());

        Console.Write("Número Períodos (mes): ");
        int numeroPeriodos = Convert.ToInt32(Console.ReadLine());

        Console.Write("Resgate do Rendimento: ");
        double resgateRendimento = Convert.ToDouble(Console.ReadLine());

        ContaInvestimento conta = new ContaInvestimento(valorPresente, taxaJuros, numeroPeriodos, resgateRendimento);

        for (int mes = 1; mes <= numeroPeriodos; mes++)
        {
            double saldoNoMes = conta.CalcularSaldoNoMes(mes);
            double rendimentoNoMes = conta.CalcularRendimentoNoMes(mes);

            Console.WriteLine($"Mês {mes}:");
            Console.WriteLine($"Saldo no Mês: {saldoNoMes:C2}");
            Console.WriteLine($"Rendimento no Mês: {rendimentoNoMes:C2}");
            Console.WriteLine($"Pode Resgatar no Mês: {(conta.PodeResgatarNoMes(mes) ? "Sim" : "Não")}");
            Console.WriteLine();
        }
    }
}
