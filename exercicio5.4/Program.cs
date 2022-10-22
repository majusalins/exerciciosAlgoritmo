// atividade 5.4: algoritmo que exibe a quantidade de números pares, ímpares,
//divisíveis por 3 e 7 e a média em um intervalo inserido pelo usuário.

int numinicial, numfinal;
int numpositivos = 0, numpares = 0, numimpares = 0, num37 = 0;
int somapos = 0, somapares = 0, somaimpares = 0, soma37 = 0;
double mediapos = 0, mediapares = 0, mediaimp = 0, media37 = 0;

Console.WriteLine("Insira o número inicial: ");
numinicial = int.Parse(Console.ReadLine());
Console.WriteLine("Insira o número final: ");
numfinal = int.Parse(Console.ReadLine());

//laço de repetição
do
{
    numinicial++;

    if (numinicial > 0)
    {

        numpositivos++;    
        somapos += numinicial;

        if (numinicial % 2 == 0)
        {
            numpares++;
            somapares += numinicial;
        }

        else
        {
            if (numinicial % 3 == 0 && numinicial % 7 == 0)
            {
                num37++;
                soma37 += numinicial;
            }

            numimpares++;
            somaimpares += numinicial;
        }

    }

} while (numinicial <= numfinal);

//cálculo de média

mediapos = somapos / numpositivos;
mediapares = somapares / numpares;
mediaimp = somaimpares / numimpares;

if (num37 == 0)
{
    media37 = soma37 / 1;
}

else
{
    media37 = soma37 / num37;
}

//a
Console.WriteLine("\n Neste intervalo, há " + numpositivos + " número(s) inteiro(s) e positivo(s).");

//b
Console.WriteLine("\n Há " + numpares + " número(s) par(es).");

//c
Console.WriteLine("\n Há " + numimpares + " número(s) ímpar(es).");

//d
Console.WriteLine("\n Há " + num37 + " número(s) ímpar(es) e divisível(is) por 3 e 7.");

//e
Console.WriteLine("\n ----- MÉDIA DOS ITENS ANTERIORES -----");
Console.WriteLine("\n Números inteiros e positivos: " + mediapos);
Console.WriteLine("\n Números pares: " + mediapares);
Console.WriteLine("\n Números ímpares: " + mediaimp);
Console.WriteLine("\n Números ímpares e divisíveis por 3 e 7: " + media37);

Console.ReadKey();