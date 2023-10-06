using System;

class Program
{
    static void Main()
    {
        decimal valorPresente = 20000.00M; 
        decimal taxaJuros = 2.00M / 100;  
        int periodoMeses = 6;             

        decimal rendaAcumulada = valorPresente;

        for (int mes = 1; mes <= periodoMeses; mes++)
        {
            decimal rendimento = valorPresente * taxaJuros;
            decimal rendaLiquida = valorPresente + rendimento;
            rendaAcumulada += rendimento;

            decimal resgate = mes == 5 ? rendaLiquida : 0; 
            rendaAcumulada -= resgate;

            Console.WriteLine($"Mês {mes}: Rendimento: R$ {rendimento:F2}, Renda Líquida: R$ {rendaLiquida:F2}, Renda Acumulada: R$ {rendaAcumulada:F2}, Resgate: R$ {resgate:F2}");

            valorPresente = rendaLiquida;
        }
    }
}

