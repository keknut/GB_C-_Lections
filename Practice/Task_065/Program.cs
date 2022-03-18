// Спирально заполнить двумерный массив

void FillArray(int[,] array) //метод заполняет массив по спирали от 1 до N
{
    int summ = array.GetLength(0) * array.GetLength(1);
    int sizeX = array.GetLength(1);
    int sizeY = array.GetLength(0);
    int correctY = 0;
    int correctX = 0;
    int count = 1;
    while (sizeY > 0)
    {
        for (int y = 0; y < 4; y++)
        {
            for (int x = 0; x < ((sizeX < sizeY) ? sizeY : sizeX); x++)
            {
                if (y == 0 && x < sizeX - correctX && count <= summ)
                    array[y + correctY, x + correctX] = count++;
                if (y == 1 && x < sizeY - correctY && x != 0 && count <= summ)
                    array[x + correctY, sizeX - 1] = count++;
                if (y == 2 && x < sizeX - correctX && x != 0 && count <= summ)
                    array[sizeY - 1, sizeX - (x + 1)] = count++;
                if (y == 3 && x < sizeY - (correctY + 1) && x != 0 && count <= summ)
                    array[sizeY - (x + 1), correctY] = count++;
            }
        }
        sizeY--;
        sizeX--;
        correctY++;
        correctX++;
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

Console.WriteLine("Enter the dimension of the array 1.");
Console.Write("Input m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Input n: ");
int n = int.Parse(Console.ReadLine());
int[,] array1 = new int[m, n];

FillArray(array1);
Console.WriteLine();
PrintArray(array1);
Console.WriteLine();
