//atividade 4.7: algoritmo que verifica se um número é par, ímpar ou 0.

int numero = 0;

Console.WriteLine("Digite um número qualquer: ");
numero = int.Parse(Console.ReadLine());

Console.WriteLine("\n Você digitou: " + numero);

if (numero == 0)
{
    Console.WriteLine("\n 0 é um número neutro.");
}

else if (numero % 2 == 0)
{
    Console.WriteLine("\n O número é par.");
}

else
{
    Console.WriteLine("\n O número é ímpar.");
}

Console.ReadKey();