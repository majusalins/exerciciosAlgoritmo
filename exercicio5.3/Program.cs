//atividade 5.3: algoritmo que mostra a tabuada até certo número.

int numero, resultado, i, j = 0;

Console.WriteLine("Digite até que número deseja visualizar a tabuada.");
numero = int.Parse(Console.ReadLine());

for (j = 1; j <= numero; j++)
{
    Console.WriteLine("\n ----- TABUADA DO " + j + " -----");
    for (i = 1; i <= 10; i++)
    {
        resultado = j * i;
        Console.WriteLine("\n " + j + " x " + i + " = " + resultado);
    }
}
Console.ReadKey();