// Показать двумерный массив размером m×n заполненный целыми числами

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

Console.WriteLine("Enter the dimension of the array.");
Console.Write("Input m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Input n: ");
int n = int.Parse(Console.ReadLine());
int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);