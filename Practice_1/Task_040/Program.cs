// В Указанном массиве вещественных чисел
//найдите разницу между максимальным и минимальным элементом

void FillArray(int[] array) //метод заполняет массив случайными числами [0; 10]
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
}

void PrintArray(int[] array) //метод выводит массив в консоль
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int DiffMaxMin(int[] array) //функция возвращает разницу между максимальным и минимальным элементом массива
{
    int result = 0;
    int max = array[0];
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) { min = array[i]; }
        if (array[i] > max) { max = array[i]; }
    }
    result = max - min;
    return result;
}

int[] array = new int[10];
FillArray(array);
PrintArray(array);
Console.WriteLine($"Difference between maximum and minimum: {DiffMaxMin(array)}");