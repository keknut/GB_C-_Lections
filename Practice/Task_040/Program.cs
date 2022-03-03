// В Указанном массиве вещественных чисел
//найдите разницу между максимальным и минимальным элементом

void FillArray(double[] array) //метод заполняет массив случайными числами [0; 10]
{
    for (int i = 0; i < array.Length; i++)
    {

        array[i] = new Random().Next(0, 10);
    }
}

void PrintArray(double[] array) //метод выводит массив в консоль
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

double DiffMaxMin(double[] array) //функция возвращает разницу между максимальным и минимальным элементом массива
{
    double result = 0;
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) { min = array[i]; }
        if (array[i] > max) { max = array[i]; }
    }
    result = max - min;
    return result;
}

double[] array = new double[10];
FillArray(array);
PrintArray(array);
Console.WriteLine($"Difference between maximum and minimum: {DiffMaxMin(array)}");