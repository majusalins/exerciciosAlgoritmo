//atividade 4.6: algoritmo que verifica se um número é par ou ímpar.

int numero = 0;

Console.WriteLine("Digite um número qualquer: ");
numero = int.Parse(Console.ReadLine());

Console.WriteLine("\n Você digitou: "+numero);

if (numero % 2 == 0)
{
    Console.WriteLine("\n O número é par.");
}

else
{
    Console.WriteLine("\n O número é ímpar.");
}

Console.ReadKey();