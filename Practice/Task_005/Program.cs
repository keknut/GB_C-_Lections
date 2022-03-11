// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

void FillArray(int[,] array) //метод заполняет массив случайными числами [0; 10]
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array) //метод выводит массив в консоль
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

double ArithmeticMeanColumn(int[,] array, int column)
{
    double result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        result += array[i, column];
    }

    return result / array.GetLength(0);
}

Console.WriteLine("Enter the dimension of the array.");
Console.Write("Input m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Input n: ");
int n = int.Parse(Console.ReadLine());
int[,] array = new int[m, n];
FillArray(array);
Console.WriteLine();
PrintArray(array);

for (int i = 0; i < array.GetLength(1); i++)
{
    Console.WriteLine($"Arithmetic mean of a column {i}: {ArithmeticMeanColumn(array, i)}");
}