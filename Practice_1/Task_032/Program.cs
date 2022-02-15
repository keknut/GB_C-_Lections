// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

void randomizeArray(int[] array) //метод заполняет массив случайными нулями и единицами
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
}

void outputArray(int[] array) //метод выводит массив в консоль
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
int[] array = new int[8];
randomizeArray(array);
outputArray(array);
