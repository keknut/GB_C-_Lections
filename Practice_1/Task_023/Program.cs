// Показать таблицу квадратов чисел от 1 до N

void squareTable(int n)
{
    for (int i = 1; i <= n; i++)
    {
        Console.WriteLine($"{i}^2 = {i * i}");
    }
}

Console.Write("Input number: ");
int n = int.Parse(Console.ReadLine());

squareTable(n);