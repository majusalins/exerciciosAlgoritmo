//atividade 4.2: algoritmo que calcula a média aritmética entre 3 valores.

float n1, n2, n3, media = 0;

Console.WriteLine("Digite o primeiro número: ");
n1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo número: ");
n2 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o terceiro número: ");
n3 = int.Parse(Console.ReadLine());

media = ((n1 + n2 + n3) / 3);

Console.WriteLine("A média aritmética dos números é " + media);

Console.ReadKey();