// Найти произведение двух матриц

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

void PrintArray(int[,] array) //метод выводит массив в консоль.
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

void MatrixProduct(int[,] array1, int[,] array2)
{
    if (array1.GetLength(1) != array2.GetLength(0))
    {
        Console.WriteLine("Multiplication impossible! Columns array 1 != rows array 2.");
    }
    else
    {
        int[,] arrayResult = new int[array1.GetLength(0), array2.GetLength(1)];
        for (int i = 0; i < array1.GetLength(0); i++)
        {
            for (int j = 0; j < array2.GetLength(1); j++)
            {
                for (int k = 0; k < array1.GetLength(1); k++)
                {
                    arrayResult[i, j] += array1[i, k] * array2[k, j];
                }
            }
        }
        Console.WriteLine("Multiplication array 1 and array 2:");
        PrintArray(arrayResult);
    }
}

Console.WriteLine("Enter the dimension of the array 1.");
Console.Write("Input m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Input n: ");
int n = int.Parse(Console.ReadLine());
int[,] array1 = new int[m, n];

FillArray(array1);
Console.WriteLine();
PrintArray(array1);
Console.WriteLine();

Console.WriteLine("Enter the dimension of the array 2.");
Console.Write("Input m: ");
m = int.Parse(Console.ReadLine());
Console.Write("Input n: ");
n = int.Parse(Console.ReadLine());
int[,] array2 = new int[m, n];

FillArray(array2);
Console.WriteLine();
PrintArray(array2);
Console.WriteLine();

MatrixProduct(array1, array2);
