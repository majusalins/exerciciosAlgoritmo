//atividade 5.10: algoritmo que calcula de cada salário os descontos relativos à varios elementos.

string nome, op;
double salariobruto, salarioajustado, impostorenda = 0, impostoinss = 0, impostototal = 0, totalpag = 0;

do
{
    Console.WriteLine("\n ----- CADASTRO DE CANDIDATO -----");
    Console.Write("\n Insira o nome do funcionário: ");
    nome = Console.ReadLine();
    Console.Write("\n Insira o salário bruto do funcionário: ");
    salariobruto = double.Parse(Console.ReadLine());

    salarioajustado = salariobruto;
    totalpag += salariobruto;

    //calcular imposto de renda

    if (salariobruto >= 1903.99 && salariobruto < 2826.66)
    {
        impostorenda += salariobruto * 0.075;
        salarioajustado = salariobruto - (salariobruto * 0.075);
    }

    else if (salariobruto >= 2826.66 && salariobruto < 3751.06)
    {
        impostorenda += salariobruto * 0.15;
        salarioajustado = salariobruto - (salariobruto * 0.15);
    }

    else if (salariobruto >= 3751.06 && salariobruto < 4664.68)
    {
        impostorenda += salariobruto * 0.225;
        salarioajustado = salariobruto - (salariobruto * 0.225);
    }

    else if (salariobruto > 4664.68)
    {
        impostorenda += salariobruto * 0.275;
        salarioajustado = salariobruto - (salariobruto * 0.275);
    }

    //calcular inss

    if (salarioajustado < 1556.95)
    {
        impostoinss += salarioajustado * 0.008;
        salarioajustado = salarioajustado - (salarioajustado * 0.008);
    }

    if (salarioajustado >= 1556.95 && salarioajustado < 2594.93)
    {
        impostoinss += salarioajustado * 0.009;
        salarioajustado = salarioajustado - (salarioajustado * 0.009);
    }

    if (salarioajustado >= 2594.93 && salarioajustado < 5189.92)
    {
        impostoinss += salarioajustado * 0.011;
        salarioajustado = salarioajustado - (salarioajustado * 0.011);
    }

    //mostrar
    Console.WriteLine("\n ----------------------");
    Console.WriteLine($"\n Nome do funcionário: {nome}");
    Console.WriteLine($"\n Salário bruto: {salariobruto.ToString("F")}");
    Console.WriteLine($"\n Salário líquido: {salarioajustado.ToString("F")}");

    impostototal = impostorenda + impostoinss;

    Console.Write("\n Deseja cadastrar outro funcionário? Digite S para sim e N para não. ");
    op = Console.ReadLine().ToUpper();

} while (op == "S");

Console.WriteLine("\n Programa finalizado!");
Console.WriteLine("\n ----------------------");
Console.WriteLine($"\n Valor total de imposto de renda que a empresa deve recolher: {impostorenda.ToString("F")}");
Console.WriteLine($"\n Valor total de inss que a empresa deve recolher: {impostoinss.ToString("F")}");
Console.WriteLine($"\n Valor total de impostos que a empresa deve recolher: {impostototal.ToString("F")}");

Console.ReadKey();