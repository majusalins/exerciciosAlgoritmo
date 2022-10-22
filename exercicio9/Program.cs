//atividade 4.9: algoritmo que calcula a média e mostra se o aluno ficou ou não de exame.

double prova1, prova2, prova3, media, exame = 0;
double mediafinal = 0;

Console.WriteLine("\n Digite sua nota na primeira avaliação: ");
prova1 = double.Parse(Console.ReadLine());
Console.WriteLine("\n Digite sua nota na segunda avaliação: ");
prova2 = double.Parse(Console.ReadLine());
Console.WriteLine("\n Digite sua nota na terceira avaliação: ");
prova3 = double.Parse(Console.ReadLine());

media = (prova1 + prova2 + prova3) / 3;

if (media >= 7)
{
    Console.WriteLine("\n Aluno APROVADO, parabéns! :)");
}

else
{
    mediafinal = (10 - media);
    Console.WriteLine("\n Aluno ficou para EXAME com média "+media+", e precisa de "+mediafinal+" ponto(s) para passar de ano!");
    Console.WriteLine("\n Digite sua nota no exame: ");
    exame = double.Parse(Console.ReadLine());    
    mediafinal = (media + exame) / 2;

    if (exame>=5)
    {
        Console.WriteLine("\n Aluno APROVADO, parabéns! :)");
    }

    else
    {
        Console.WriteLine("\n Aluno REPROVADO. :(");
    }
}

Console.ReadKey();