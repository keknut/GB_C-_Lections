// Составить частотный словарь элементов двумерного массива
// Частотный словарь содержит информацию о том,
// сколько раз встречается элемент входных данных.

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

void PrintArray(int[,] array) //метод выводит массив в консоль.
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

//метод выводит частоту встречаемых элементов в словаре
void PrintDigitsOccurs(int[,] array,int k)
{
    for (int i = 0; i < k; i++)
    {
        Console.Write($"{array[i, 0]} occurs {array[i,array.GetLength(1) - 1]} times.");
        Console.WriteLine();
    }
}

void DigitOccurs(int[,] array)
{
    int[,] elements = new int[array.GetLength(0) * array.GetLength(1), 2];
    int k = 0;
    bool flag = true; // Флаг нужен для словаря.
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int l = 0; l < k; l++)
            {
                if (elements[l, 0] == array[i, j])
                {
                    elements[l, 1]++;
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                elements[k, 0] = array[i, j];
                elements[k, 1]++;
                k++;
            }
            flag = true;
        }
    }
    PrintDigitsOccurs(elements, k);
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

DigitOccurs(array);