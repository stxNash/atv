using System;

class Program
{
    static void Main()
    {
        decimal valorFuturo = 7390.61M; 
        decimal taxaJuros = 2.00M / 100;  

        decimal valorPresente = valorFuturo / (decimal)Math.Pow(1 + (double)taxaJuros, 3); 
        

        Console.WriteLine($"Valor Presente necessário para obter R$ {valorFuturo:F2} em 3 anos somados com a taxa de juros: R$ {valorPresente:F2}");
    }
}
