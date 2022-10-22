//atividade 5.6: algorimo que identifica se o número é par ou ímpar e, dependendo de qual,
//realiza diferentes instruções.

int numero;

Console.WriteLine("Insira um número qualquer: ");
numero = int.Parse(Console.ReadLine());

if (numero != 1)
{
    if (numero % 2 == 0)
    {
        numero = numero / 2;
        Console.WriteLine("\n O número digitado é par, portanto foi dividido por dois e o resultado é: " + numero);
    }

    else
    {
        numero = numero * 3 + 1;
        Console.WriteLine("\n O número digitado é ímpar, portanto foi multiplicado por três e somado a um, e o resultado é: " + numero);
    }
} 

else
{
    Console.WriteLine("\n Digite um número diferente de 1!");
}

Console.ReadKey();