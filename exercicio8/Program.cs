//atividade 4.8: algoritmo que verifica se um número é múltiplo de 3 ou de 7.

int numero = 0;

Console.WriteLine("Digite um número qualquer: ");
numero = int.Parse(Console.ReadLine());

Console.WriteLine("\n Você digitou: " + numero);

if (numero % 3 == 0)
{
    Console.WriteLine("\n O número é múltiplo de 3.");
}

else if (numero % 7 == 0)
{
    Console.WriteLine("\n O número é múltiplo de 7.");
}

else
{
    Console.WriteLine("\n O número não é múltiplo nem de 3 e nem de 7.");
}

Console.ReadKey();