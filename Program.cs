﻿Console.Write("Números.....: ");
int quantidade = Convert.ToInt32(Console.ReadLine());

decimal numeroDigitado;
int contador = 0;

decimal soma = 0;
decimal NumeroMaior = 999999.99M;
decimal NumeroMenor = 999999.99M;

while (contador < quantidade)
{
    contador += 1;
    Console.Write($"Número {contador}.....: ");
    numeroDigitado = Convert.ToDecimal(Console.ReadLine());
    soma = soma + numeroDigitado;

    if (contador == 1)
    {
        NumeroMaior = numeroDigitado;
        NumeroMenor = numeroDigitado;
    }

    if (numeroDigitado > NumeroMaior)
    {
        NumeroMaior = numeroDigitado;
    }

    if (numeroDigitado <NumeroMenor)
    {
        NumeroMenor = numeroDigitado;
    }
}

if (contador > 0)
{
    decimal media = soma / quantidade;

    Console.WriteLine($"\nSoma...: {soma:N2}");
    Console.WriteLine($"Média....: {media:N2}");
    Console.WriteLine($"Menor....: {NumeroMenor:N2}");
    Console.WriteLine($"Maior....: {NumeroMaior:N2}");
}