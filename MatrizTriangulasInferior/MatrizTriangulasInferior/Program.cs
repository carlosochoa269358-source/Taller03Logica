Console.Write("Ingrese orden de la matriz: ");
int n = int.Parse(Console.ReadLine());

int[,] matrix = new int[n, n];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = i + j;
    }
}


for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write($"{matrix[i, j],4}");
    }
    Console.WriteLine();
}

Console.WriteLine();


for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (j <= i)
        {
            Console.Write($"{matrix[i, j],4}");
        }
        else
        {
            Console.Write("    ");
        }
    }
    Console.WriteLine();
}
