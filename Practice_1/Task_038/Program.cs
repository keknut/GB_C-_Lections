// Найти сумму чисел одномерного массива стоящих на нечетной позиции

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

int SummOddIndex(int[] array){
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            result = result + array[i];
        }
    }
    return result;
}

int[] array = new int[10];
FillArray(array);
PrintArray(array);

Console.WriteLine($"Sum of array elements with odd index: {SummOddIndex(array)}");
