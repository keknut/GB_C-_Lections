// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

void FillArray(int[] array) //метод заполняет массив случайными числами [0; 199]
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 200);
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

int AmountElements(int[] array)//возвращает количество элементов в массиве на отрезке [10; 99]
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <= 99)
        {
            result++;
        }
    }
    return result;
}

int[] array = new int[123];

FillArray(array);
PrintArray(array);
Console.WriteLine($"Amount of elements [10; 99] in array: {AmountElements(array)}");