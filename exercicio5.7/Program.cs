//atividade 5.7: algoritmo que calcula a mediana em um intervalo definido pelo usuário.

int numinicial, numfinal;
List<int> numeros = new List<int>();
double mediana;

Console.Write("Insira o número inicial: ");
numinicial = Convert.ToInt32(Console.ReadLine());
Console.Write("Insira o número final: ");
numfinal = Convert.ToInt32(Console.ReadLine());

for (int i = numinicial; i <= numfinal; i++)
{
    numeros.Add(i);
}

if (numeros.Count % 2 == 0)
{
    mediana = (numeros[(numeros.Count / 2) - 2] + numeros[(numeros.Count / 2) - 1] / 2);
}

else
{
    mediana = numeros[(numeros.Count / 2)];
}

Console.WriteLine("A mediana é: " + mediana);

Console.ReadKey();