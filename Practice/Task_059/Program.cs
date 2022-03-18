// В прямоугольной матрице
// найти строку с наименьшей суммой элементов.

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

void RowSmallestSum(int[,] array){
    int minSum = 0;
    int currentSum = 0;
    int rowIndexMinSum = 0;
    // Находим сумму первой строчки и помещаем в переменную minSum
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minSum = minSum + array[0, i];
    }
    // Начинаем с первого индекса, потому что сумму первой строки мы уже нашли
    for (int i = 1; i < array.GetLength(0); i++)
    {
        // Обнуляем текующую сумму
        currentSum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            currentSum = currentSum + array[i, j];
        }
        // Если сумма текущей строки меньше суммы уже найденной
        // Присваиваем переменной minSum новое значение текущей
        if(currentSum < minSum){
            minSum = currentSum;
            rowIndexMinSum = i;
        }
    }
    Console.WriteLine($"Row {rowIndexMinSum} with the smallest sum of: {minSum}");
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
RowSmallestSum(array);