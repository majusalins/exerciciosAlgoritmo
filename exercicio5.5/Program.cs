//atividade 5.5: algoritmo que exibe a sequência de Fibonacci até um termo
//especificado pelo usuário.

int numerotermos, num1 = 0, fib = 0;
int num2 = 1;

Console.WriteLine("Insira até que termo deseja visualizar a sequência de Fibonacci: ");
numerotermos = int.Parse(Console.ReadLine());

for (int i = 1; i <= numerotermos; i++)
{
    fib  = num1 + num2;
    Console.WriteLine("\n * " + fib);
    num1 = num2;
    num2 = fib;
}

Console.ReadKey();