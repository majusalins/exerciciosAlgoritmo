//atividade 4.5: algoritmo que calcula desconto de 10%.

double precoatual, precodesconto = 0;
string produto = " ";

Console.WriteLine("Insira o nome do produto: ");
produto = Console.ReadLine();
Console.WriteLine("Insira o preço atual do produto: ");
precoatual = float.Parse(Console.ReadLine()); 

precodesconto = precoatual - (precoatual * 0.10);

Console.WriteLine("\n * NOME DO PRODUTO: " + produto + "\n * VALOR ATUAL: " + precoatual + "\n * VALOR COM DESCONTO: " + precodesconto);

Console.ReadKey();
