// Задать массив, заполнить случайными положительными трёхзначными числами.
//Показать количество нечетных\четных чисел

void FillArray(int[] array) //метод заполняет массив случайными числами [100; 1000]
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
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

int EvenNumbers(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            result++;
        }
    }
    return result;
}

int OddNumbers(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 != 0)
        {
            result++;
        }
    }
    return result;
}

int[] array = new int[10];
FillArray(array);
PrintArray(array);

Console.WriteLine($"Number of even numbers in the array: {EvenNumbers(array)}");
Console.WriteLine($"Number of odd numbers in the array: {OddNumbers(array)}");