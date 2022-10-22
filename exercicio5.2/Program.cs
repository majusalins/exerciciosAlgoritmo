//atividade 5.2: algoritmo que calcula quantos anos serão necessários para que ambos tenham a mesma altura
//e para que lucas seja maior que pedro.

double alturapedro = 1.50;
double alturalucas = 1.10;
int ano = 0;

//a
do
{
    alturapedro = alturapedro + 0.02;
    alturalucas = alturalucas + 0.03;
    ano++;
    Console.WriteLine("\n * A altura de Pedro é " + alturapedro + " cm e a altura de Lucas é " + alturalucas + " cm.");

}while (alturapedro >= alturalucas);

Console.WriteLine("\n * Irá levar "+ano+" anos até que ambos tenham a mesma altura.");


//b
do
{
    alturapedro = alturapedro + 0.02;
    alturalucas = alturalucas + 0.03;
    ano++;
    Console.WriteLine("\n * A altura de Pedro é "+alturapedro+" cm e a altura de Lucas é "+alturalucas+" cm.");

} while (alturapedro > alturalucas);

Console.WriteLine("\n * Irá levar "+ano+" anos até que Lucas seja maior que Pedro.");

Console.ReadKey();