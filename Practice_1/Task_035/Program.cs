// Определить, присутствует ли в заданном массиве, некоторое число

void FillArray(int[] array) //метод заполняет массив случайными числами [-9; 9]
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

void IsThereNumber(int[] array, int number) //Выводит сообщение, присутствует ли в массиве то или иное число
{
    bool flag = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
        {
            flag = true;
            break;
        }
    }
    if (flag)
    {
        Console.WriteLine($"The number {number} is present in the array");
    }
    else
    {
        Console.WriteLine($"The number {number} is missing from the array");
    }
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);

Console.Write("Input number: ");
int number = int.Parse(Console.ReadLine());

IsThereNumber(array, number);