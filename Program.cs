static void Fatorial(int numero)
{
    long resultado = 1;

    for (int j = 2; j <= numero; j++)
    {
        Console.WriteLine($"Saída: {resultado *= j}");
    }
}

Fatorial(5);

































// static void meuNumero(int numero)
// {
//     for (int i = 1; i <= numero; i++)
//     {
//         Console.WriteLine($"-> {i}");
//     }

//     Console.WriteLine($"Seu número é o {numero}");
// }

// meuNumero(10000);



// static void meuNumero(int numero)
// {
//     string linha = "";

//     for (int i = 1; i <= numero; i++)
//     {
//         linha = linha + " " + numero;
//     }
//     for (int i = 1; i <= numero; i++)
//     {
//         Console.WriteLine($"{linha}");
//     }

//     Console.WriteLine($"Seu número é - {numero}");
// }

// meuNumero(7);