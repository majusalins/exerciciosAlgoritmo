//atividade 4.1: algoritmo que lê 4 valores, calcula a soma entre eles e apresenta o resultado.

float num1, num2, num3, num4, soma = 0;

Console.WriteLine("Digite o primeiro número: ");
num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo número: ");
num2 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o terceiro número: ");
num3 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o quarto número: ");
num4 = int.Parse(Console.ReadLine());


soma = (num1 + num2 + num3 + num4);

Console.WriteLine("\n A soma dos quatro números informados é " + soma);

Console.ReadKey();