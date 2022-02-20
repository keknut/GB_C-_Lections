// Задать массив из 12 элементов, заполненных числами из [0,9].
//Найти сумму положительных/отрицательных элементов массива

void PrintArray(int[] array) //метод выводит массив в консоль
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void FillArray(int[] array) //метод заполняет массив случайными числами [-9; 9]
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
}

int SumPositive(int[] array)  //функция считает и возвращает сумму положительных элементов массива
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            result = result + array[i];
        }
    }
    return result;
}

int SumNegative(int[] array)  //функция считает и возвращает сумму отрицательных элементов массива
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            result = result + array[i];
        }
    }
    return result;
}

int[] array = new int[12];
FillArray(array);
PrintArray(array);
Console.WriteLine($"Summ positive: {SumPositive(array)}");
Console.WriteLine($"Summ negative: {SumNegative(array)}");