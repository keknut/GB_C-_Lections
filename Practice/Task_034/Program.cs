// Написать программу замену элементов массива на противоположные

void FillArray(int[] array) //метод заполняет массив случайными числами [-9; 9]
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
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

void ReverseArray(int[] array){
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * (-1);
    }
}

int[] array = new int[10];
FillArray(array);
PrintArray(array);
ReverseArray(array);
PrintArray(array);