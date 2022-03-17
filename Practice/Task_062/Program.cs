// В двумерном массиве целых чисел. Удалить строку и столбец,
// на пересечении которых расположен наименьший элемент.

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

void DeleteLineColumn(int[,] array, int[,] newArray, int deleteLine, int deleteColumn)
{
    for (int i = 0; i < newArray.GetLength(0); i++)
    { 
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            newArray[i ,j] = array[i, j] ;
            if (i == deleteLine)
            {
                newArray[i, j] = array[i + 1, j];
            }
        }
        if(i == deleteLine){
            deleteLine++;
        }
    }
    for (int i = 0; i < newArray.GetLength(0); i++)
    { 
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            newArray[j ,i] = array[j, i] ;
                if(i == deleteColumn)
            {
                newArray[j, i] = array[j, i + 1];
            }
        }
        if(i == deleteColumn){
            deleteColumn++;
        }
    }
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

int min = array[0, 0];
int minI = 0;
int minJ = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i, j] < min)
        {
            min = array[i, j];
            minI = i;
            minJ = j;
        }
    }
}
Console.WriteLine($"i: {minI} j: {minJ}");
Console.WriteLine();
int [,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
DeleteLineColumn(array, newArray, minI, minJ);
PrintArray(newArray);