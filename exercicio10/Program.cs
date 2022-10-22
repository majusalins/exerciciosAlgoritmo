//atividade 4.10: algoritmo que lê o valor de uma compra e calcula o valor total
//de acordo com o método de pagamento escolhido.

double valortotal, valormod, parcela = 0;
int op = 0;

Console.WriteLine("\n * Insira o valor total da compra: ");
valortotal = double.Parse(Console.ReadLine());
Console.WriteLine("\n * Selecione a forma de pagamento:" +
    "\n * Digite '1' para pagamento à vista." +
    "\n * Digite '2' para pagamento em 3 parcelas." +
    "\n * Digite '3' para pagamento em 5 parcelas." +
    "\n * Digine '4' para pagamento em 10 parcelas.");
op = int.Parse(Console.ReadLine());

switch (op)
{
    case 1:
        valormod = valortotal - (valortotal * 0.05);
        Console.WriteLine("\n * PAGAMENTO À VISTA. TOTAL: R$"+ valormod + ".");
        break;

    case 2:
        parcela = valortotal / 3;
        Console.WriteLine("\n * PAGAMENTO PARCELADO, TOTAL DE R$"+ valortotal +" EM 3 PARCELAS DE R$"+ parcela +".");
        break;

    case 3:
        valormod = valortotal + (valortotal * 0.02);
        parcela = valormod / 5;
        Console.WriteLine("\n * PAGAMENTO PARCELADO, TOTAL DE R$"+ valormod + " EM 5 PARCELAS DE R$"+ parcela +".");
        break;

    case 4:
        valormod = valortotal + (valortotal * 0.08);
        parcela = valormod / 10;
        Console.WriteLine("\n * PAGAMENTO PARCELADO, TOTAL DE R$" + valormod + " EM 10 PARCELAS DE R$" + parcela + ".");
        break;

    default:
        Console.WriteLine("\n * Insira uma opção válida!");
        break;
}

Console.ReadKey();