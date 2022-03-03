// Написать программу копирования массива

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

void CopyArray(int[] mainArray, int[] copiedArray){
    for (int i = 0; i < mainArray.Length; i++)
    {
        copiedArray[i] = mainArray[i];
    }
}

int[] array = new int[10];

FillArray(array);
Console.Write("Main array: ");
PrintArray(array);

int[] copyArray = new int[array.Length];

CopyArray(array, copyArray);
Console.Write($"Copied array: ");
PrintArray(copyArray);