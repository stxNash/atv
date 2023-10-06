using System;
class Program

{
    static void Main()

    {
        decimal valorPresente = 1000.00M; 

        decimal taxaJuros = 5.30M / 100;  

        int periodoMes = 10;               

        decimal valorFuturo = valorPresente * (decimal)Math.Pow(1 + (double)taxaJuros, periodoMes);

        Console.WriteLine($"Valor Futuro após {periodoMes} meses: R$ {valorFuturo:F2}");
    }
    
}
