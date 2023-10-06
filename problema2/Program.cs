using System;

class Program
{
    static void Main()
    {
        decimal valorPresente = 3800.00M; 
        decimal taxaJuros = 1.25M / 100; 
        int periodoMeses = 6;           

        decimal rendaAcumulada = valorPresente;

        for (int mes = 1; mes <= periodoMeses; mes++)
        {
            decimal rendimento = valorPresente * taxaJuros;
            decimal rendaLiquida = valorPresente + rendimento;
            rendaAcumulada += rendimento;
            
            Console.WriteLine($"Mês {mes}: Rendimento: R$ {rendimento:F2}, Renda Líquida: R$ {rendaLiquida:F2}, Renda Acumulada: R$ {rendaAcumulada:F2}");
            
            valorPresente = rendaLiquida;
        }
    }
}

