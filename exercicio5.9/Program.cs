//atividade 5.9: algoritmo que recebe informações de perfis de candidatos e realiza o tratamento dos dados.

string nome, sexo, exp, op;
int idade, escolaridade, candidatosfem = 0, candidatosmasc = 0, mediaexpmasc = 0, mediaexpfem = 0, porcenthomens = 0, menoridade = 0;
int soma1 = 0, soma2 = 0, idadefem, idademasc, efund = 0, emedio = 0, grad = 0, posgrad = 0;

do
{
    Console.WriteLine("\n ----- CADASTRO DE CANDIDATO -----");
    Console.Write("\n Nome: ");
    nome = Console.ReadLine();
    Console.Write("\n Idade: ");
    idade = int.Parse(Console.ReadLine());
    Console.Write("\n Sexo (F ou M): ");
    sexo = Console.ReadLine().ToUpper();
    Console.Write("\n Possui experiência? (S ou N) ");
    exp = Console.ReadLine().ToUpper();
    Console.Write("\n Qual o nível de escolaridade? (1 para E. Fundamental, 2 para E. Médio, " +
        "3 para E. Superior e 4 para Pós Graduação) ");
    escolaridade = int.Parse(Console.ReadLine());

    if (escolaridade == 1)
    {
        efund++;
    }

    else if (escolaridade == 2)
    {
        emedio++;
    }

    else if (escolaridade == 3)
    {
        grad++;
    }

    else if (escolaridade == 4)
    {
        posgrad++;
    }

    else
    {
        Console.WriteLine("Selecione uma opção válida!");
    }

    if (sexo == "F")
    {
        candidatosfem++;
        idadefem = idade;
        soma1 = soma1 + idadefem;

        if (sexo == "F" && exp == "S")
        {
            mediaexpfem = soma1 / candidatosfem;

            if (menoridade == 0)
            {
                menoridade = idadefem;
            }

            if (idadefem < menoridade)
            {
                menoridade = idadefem;
            }
        }
    }

    else
    {
        candidatosmasc++;
        idademasc = idade;
        soma2 = soma2 + idademasc;

        if (sexo == "M" && exp == "S")
        {
            mediaexpmasc = soma2 / candidatosmasc;
        }

        if (idademasc >= 35 && idademasc <= 45)
        {
            porcenthomens += 1;
            porcenthomens = (porcenthomens * 100) / candidatosmasc;
        }
    }

    Console.Write("\n Deseja cadastrar outro candidato? Digite SIM ou NÃO: ");
    op = Console.ReadLine().ToUpper();

} while (op == "SIM");

Console.WriteLine("\n ----- INFORMAÇÕES DE CANDIDATOS -----");
Console.WriteLine("\n Candidatas do sexo feminino: " + candidatosfem);
Console.WriteLine("\n Candidatos do sexo masculino: " + candidatosmasc);
Console.WriteLine("\n Idade média dos homens com experiência: " + mediaexpmasc);
Console.WriteLine("\n Idade média das mulheres com experiência: " + mediaexpfem);
Console.WriteLine("\n Porcentagem de homens cadastrados entre 35 e 45 anos: " + porcenthomens + "%");
Console.WriteLine("\n Menor idade entre mulheres com experiência: " + menoridade);
Console.WriteLine("\n Nível de escolaridade dos candidatos: \n * " + efund + " candidatos com nível fundamental \n * " + emedio +
    " candidatos com nível médio \n * " + grad + " candidatos com ensino superior \n * " + posgrad + " candidatos com pós-graduação.");

Console.ReadKey();