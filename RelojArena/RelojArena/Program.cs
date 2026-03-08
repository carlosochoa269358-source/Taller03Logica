Console.Write("Ingrese orden de la matriz: ");
int n = int.Parse(Console.ReadLine());

int[,] matrix = new int[n, n];


for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = i * 2 + j;
    }
}


Console.WriteLine("MATRIZ COMPLETA");

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write($"{matrix[i, j],4}");
    }
    Console.WriteLine();
}

string[,] a = new string[n, n];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        a[i, j] = "";
    }
}

int x = (n / 2) + 1;

for (int i = 0; i < x; i++)
{
    for (int j = i; j < n - i; j++)
    {
        a[i, j] = matrix[i, j].ToString();
        a[n - i - 1, j] = matrix[n - i - 1, j].ToString();
    }
}

Console.WriteLine("RELOJ DE ARENA");

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write($"{a[i, j],4}");
    }
    Console.WriteLine();
}

