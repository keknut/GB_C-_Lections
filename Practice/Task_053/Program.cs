// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет

void FillArray(int[,] array) //метод заполняет массив случайными числами [0; 10]
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array) //метод выводит массив в консоль
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int SearchElement(int[,] array, int m, int n)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == m && j == n)
            {
                return array[i,j];
            }
        }
    }
    return 0;
}

Console.WriteLine("Enter the dimension of the array.");
Console.Write("Input m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Input n: ");
int n = int.Parse(Console.ReadLine());
int[,] array = new int[m, n];
FillArray(array);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
Console.Write("Input i: ");
m = int.Parse(Console.ReadLine());
Console.Write("Input j: ");
n = int.Parse(Console.ReadLine());
if(SearchElement(array, m, n) == 0){
    Console.WriteLine("No such element exists.");
} else{
    Console.WriteLine($"Array[{m},{n}]: {SearchElement(array, m , n)}");
}
