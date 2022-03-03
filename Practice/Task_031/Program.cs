// Задать массив из 8 элементов и вывести их на экран

void outputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int[] array = { 1, 2, 3, 4, 5, 6, 7, 8 };

outputArray(array);