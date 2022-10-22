//exercicio 5.8: algoritmo que recebe números até que o usuário encerre o programa.
//no pdf não há o exercício de referência, portanto a soma foi decidida por conta.

int num1, num2, num3, num4, soma;
string opcao;

do
{
    Console.WriteLine("\n Digite o primeiro número: ");
    num1 = int.Parse(Console.ReadLine());
    Console.WriteLine("\n Digite o segundo número: ");
    num2 = int.Parse(Console.ReadLine());
    Console.WriteLine("\n Digite o terceiro número: ");
    num3 = int.Parse(Console.ReadLine());
    Console.WriteLine("\n Digite o quarto número: ");
    num4 = int.Parse(Console.ReadLine());

    soma = num1 + num2 + num3 + num4;

    Console.WriteLine("\n A soma é " + soma);
    Console.WriteLine("\n Deseja continuar? Digite SIM ou NÃO.");
    opcao = Console.ReadLine().ToUpper();

} while (opcao == "SIM");

Console.WriteLine("\n Programa finalizado.");

Console.ReadKey();