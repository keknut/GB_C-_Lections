// В матрице чисел найти сумму элементов главной диагонали

void FillArray(int[,] array) //метод заполняет массив случайными вещественными числами [0; 1]
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
            if(i == j){
                Console.ForegroundColor = ConsoleColor.Green; // Подкрашиваем главную диагональ для удобства, изменяя цвет текста.
            }
            Console.Write($"{array[i, j]} ");
            Console.ResetColor(); // Сбрасываем цвет текста в консоли
        }
        Console.WriteLine();
    }
}

int SumElementsMainDiagonal(int[,] array)
{
    int result = 0;
    int maxLength = 0;
    if(array.GetLength(0) > array.GetLength(1)){
        maxLength = array.GetLength(1);
    }else{
        maxLength = array.GetLength(0);
    }
    for (int i = 0; i < maxLength; i++)
    {
        result += array[i, i];
    }
    return result;
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
Console.WriteLine($"The sum of the elements of the main diagonal: {SumElementsMainDiagonal(array)}");