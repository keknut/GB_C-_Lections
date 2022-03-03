﻿// В двумерном массиве целых чисел. Удалить строку и столбец,
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

int CoordinatesMinElement(int[,] array){
    int min = 0;
    int minI = 0;
    int minJ = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i, j] < min){
                min = array[i, j];
                minI = i;
                minJ = j;
            }
        }
        return minI, minJ;
    }
}

/* void DeleteLineColumn(int[,] array, int deleteLine, int deleteColumn){
    int primaryDeleteColumn = deleteColumn;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        deleteColumn = primaryDeleteColumn;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(j == deleteColumn && j != (array.GetLength(1) - 1)){
                array[i,j] = array[i, j+1];
                deleteColumn++;
            }
            if(i == deleteLine){
                array[i, j] = array[i + 1, j];
            }
        }
    }
}
 */
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

Console.WriteLine(CoordinatesMinElement(array));
//DeleteLineColumn(array, CoordinatesMinElement(array));