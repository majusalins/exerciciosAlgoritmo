//atividade 4.3: algoritmo que calcula o valor de venda de um produto e exibe código, nome, quantidade comprada e valor total.

string cod, nome = " ";
float valuni, valtotal = 0;
int quant = 0;

Console.WriteLine("Insira o código do produto: ");
cod = Console.ReadLine();

Console.WriteLine("Insira o nome do produto: ");
nome = Console.ReadLine();

Console.WriteLine("Qual é o valor unitário do produto?");
valuni = float.Parse(Console.ReadLine());

Console.WriteLine("Quantas unidades foram vendidas?");
quant = int.Parse(Console.ReadLine());

valtotal = (valuni * quant);

Console.WriteLine("------NOTA DE VENDA------");
Console.WriteLine("\n * CÓDIGO DO PRODUTO: " + cod + "\n * NOME DO PRODUTO: " + nome + "\n * UNIDADES COMPRADAS: "
    + quant + "\n * VALOR UNITÁRIO: " + valuni + "\n * VALOR TOTAL: " + valtotal);

Console.ReadKey();