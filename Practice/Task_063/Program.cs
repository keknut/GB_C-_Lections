// Сформировать трехмерный массив не повторяющимися
// двузначными числами показать его построчно
// на экран выводя индексы соответствующего элемента


void FillArray(int[,,] array) //метод заполняет массив случайными числами [0; 10]
{
    int l = 0;
    int[] arrayDigits = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
    array[0, 0, 0] = new Random().Next(10, 100);
    arrayDigits[0] = array[0, 0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                l = 0;
                array[i, j, k] = new Random().Next(10, 100);
                while (l < arrayDigits.GetLength(0))
                {
                    if(arrayDigits[l] == 0){
                        arrayDigits[l] = array[i, j, k];
                        break;
                    }
                    if (array[i, j, k] == arrayDigits[l])
                    {
                        l = 0;
                        array[i, j, k] = new Random().Next(10, 100);
                    } else {
                        l++;
                    }
                }
            }
        }
    }
}

void PrintArray(int[,,] array) //метод выводит массив в консоль.
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Enter the dimension of the array.");
Console.Write("Input m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Input n: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Input k: ");
int k = int.Parse(Console.ReadLine());
int[,,] array = new int[m, n, k];

if (m * n * k > 90)
{
    Console.WriteLine(
        "The array size specified is too large. It is impossible to fill it with non-repeating two-digit numbers."
    );
}
else
{
    Console.WriteLine();
    FillArray(array);
    PrintArray(array);
}