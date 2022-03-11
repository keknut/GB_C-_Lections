// Найти кубы чисел от 1 до N

void cubeTable(int n)
{
    for (int i = 1; i <= n; i++)
    {
        Console.WriteLine($"{i}^3 = {i * i * i}");
    }
}

Console.Write("Input number: ");
int n = int.Parse(Console.ReadLine());

cubeTable(n);
