// Найти произведение пар чисел в одномерном массиве.
//Парой считаем первый и последний элемент, второй и предпоследний и т.д.

void FillArray(int[] array) //метод заполняет массив случайными числами [0; 9]
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

void SumPairs(int[] array)
{
    for (int i = 0; i < (array.Length + 1) / 2; i++)
    {
        Console.WriteLine($"Product of pairs  {i} & {array.Length - i}: {array[i] * array[array.Length - 1 - i]}");
    }
}

int[] array = new int[10];
FillArray(array);
PrintArray(array);
SumPairs(array);