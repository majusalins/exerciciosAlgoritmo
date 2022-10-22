//atividade 4.4: algoritmo que calcula o reajuste salarial de 8,75% baseado no salário informado.

string nomefun = " ";
double salatual, salreajuste = 0;

Console.WriteLine("Insira o nome do funcionário: ");
nomefun = Console.ReadLine();

Console.WriteLine("Insira o salário atual do funcionário: ");
salatual = double.Parse(Console.ReadLine());

salreajuste = (salatual + (salatual * 0.0875));

Console.WriteLine("---- REAJUSTE SALARIAL----");
Console.WriteLine("\n * NOME DO FUNCIONÁRIO: " + nomefun + "\n * SALÁRIO ATUAL: " + salatual + "\n * SALÁRIO REAJUSTADO: " + salreajuste);

Console.ReadKey();