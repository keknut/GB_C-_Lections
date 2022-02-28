// В двумерном массиве n×k заменить четные элементы на противоположные

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

void ReverseEvenElements(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] % 2 == 0)
            {
                array[i, j] = array[i, j] * (-1);
            }
        }
    }
}

Console.WriteLine("Enter the dimension of the array.");
Console.Write("Input n: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Input k: ");
int k = int.Parse(Console.ReadLine());
int[,] array = new int[n, k];
FillArray(array);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
ReverseEvenElements(array);
PrintArray(array);