// See https://aka.ms/new-console-template for more information
int m, n;
Console.Write("Ввод M: ");
m=Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Ввод N: ");
n =Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
try
{
    double[,] vs = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            vs[i, j] = Math.Sin(i + j / 2);
            Console.Write("{0,6}", vs[i, j] + "; ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    int koll = 0;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (vs[i, j] > 0) koll++;
        }
    }
    Console.Write($"Колличество положительных эллементов равно: {koll}");
}
catch
{
    Console.WriteLine("Ошибка при вводе переменных");
}
